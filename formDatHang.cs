using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT
{
    public partial class formDatHang : Form
    {
        public String maKho = null;
        public String maDonDH = null;
        Dictionary<string, string> listVatTuChuaDat = null;
        public formDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void formDatHang_Load(object sender, EventArgs e)
        {
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);

            btnGhi.Enabled = false;

            //-----------------------chi tiet don dat hang
            btnGhi_CTDDH.Enabled = gbTTCT_CTDDH.Enabled = false;


            //--------------
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            btnHuy_CTDDH.Enabled = false;
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnThem_CTDDH.Enabled = btnXoa_CTDDH.Enabled = false;
                cmbChiNhanh.Enabled = true;
            }
            else cmbChiNhanh.Enabled = btnGhi.Enabled = false;

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Phai load lai kho xem kho co duoc cap nhat khong
            this.khoTableAdapter.Fill(this.DS.Kho);

            bdsDatHang.AddNew();
            txtMaNV.Text = Program.username;
            txtMaDDH.Text = Program.getMaDH();
            txtNgay.Value = DateTime.Now;
            gbTTDDH.Enabled = btnGhi.Enabled = true;
            txtMaNV.Enabled = btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnNhapHang.Enabled = groupBox6.Enabled = false;
            txtMaKho.Text = cbxKho.SelectedValue.ToString();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKho.Text == "" || txtMaDDH.Text == "" || txtMaNV.Text == "" || txtNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtMaDDH.Text.Length < 4 || !txtMaDDH.Text.Trim().Substring(0, 4).Equals("MDDH"))
            {
                MessageBox.Show("Mã đơn đặt hàng phải đúng định dạng MDDHxxxx", "Thông báo", MessageBoxButtons.OK);
                txtMaDDH.Text = Program.getMaDH().ToString();
                return;
            }
            try
            {
                //Kiểm tra maDatHang xem có bị trùng ko
                String lenh = "EXEC [sp_KTMaDH] '" + txtMaDDH.Text.Trim() + "'";
                SqlDataReader kt = Program.ExecSqlDataReader(lenh);
                if (kt == null) return;
                kt.Read();
                int i = (int)kt.GetInt32(0);
                kt.Close();
                if (i != 0)
                {
                    MessageBox.Show("Mã đơn đặt hàng bị trùng !", "", MessageBoxButtons.OK);
                    txtMaDDH.Text = Program.getMaDH().ToString();
                    return;
                }
            }
            catch (Exception ex)
            {

            }
            try
            {
                bdsDatHang.EndEdit();
                bdsDatHang.ResetCurrentItem(); //lấy dữ liệu đẩy lên lưới cập nhật những gì trên màn hình lên lưới
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;

                this.datHangTableAdapter.Update(this.DS.DatHang);  //cập nhật vào database
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đơn hàng " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gbTTDDH.Enabled = btnGhi.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnThem_CTDDH.Enabled = btnRefresh.Enabled = btnNhapHang.Enabled = groupBox6.Enabled = true;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Đã có chi tiết đơn đặt hàng, không thể xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (MessageBox.Show("Bạn thực sự muốn xóa đơn hàng?", "Lưu ý", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsDatHang.RemoveCurrent();
                    bdsDatHang.ResetCurrentItem(); //lấy dữ liệu đẩy lên lưới cập nhật những gì trên màn hình lên lưới
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;

                    this.datHangTableAdapter.Update(this.DS.DatHang);  //cập nhật vào database
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa đơn hàng " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void cbxKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKho.SelectedValue != null)
                txtMaKho.Text = cbxKho.SelectedValue.ToString();
        }

        private void btnThem_CTDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Truoc khi them moi phai load lai xem vat tu co cap nhat moi khong
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            cbxVatTu_CTDDH1.Items.Clear();
            listVatTuChuaDat = new Dictionary<string, string>();
            int countVatTu = bdsVatTu.Count;
            for (int i = 0; i < countVatTu; i++)
            {
                DataRowView tro = (DataRowView)bdsVatTu[i];
                listVatTuChuaDat.Add(tro["MAVT"].ToString().Trim(), tro["TENVT"].ToString().Trim());
                cbxVatTu_CTDDH1.Items.Add(tro["TENVT"].ToString().Trim());
            }

            int countCTDH = bdsCTDDH.Count;
            for (int i = 0; i < countCTDH; i++)
            {
                DataRowView tro = (DataRowView)bdsCTDDH[i];
                string maVTCTDH = tro["MAVT"].ToString().Trim();
                cbxVatTu_CTDDH1.Items.Remove(listVatTuChuaDat[maVTCTDH]);
                listVatTuChuaDat.Remove(maVTCTDH);
            }
            if (cbxVatTu_CTDDH1.Items.Count == 0)
            {
                MessageBox.Show("Tất cả các vật tư đã được thêm vào chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            bdsCTDDH.AddNew();
            txtMaDonDH_CTDDH.Text = txtMaDDH.Text;
            cbxVatTu_CTDDH1.SelectedIndex = 0;
            txtMaVT_CTDDH.Text = listVatTuChuaDat.ElementAt(0).Key.Trim();
            groupBox5.Enabled = groupBox6.Enabled = false;
            gbTTCT_CTDDH.Enabled = true;
            txtDonGia_CTDDH.Value = 0;
            txtSoLuong_CTDDH.Value = 0;
            ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["DONGIA"] = 0;
            ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["SOLUONG"] = 0;



        }

        private void btnXoa_CTDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa vật tư này?", "Lưu ý", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bdsCTDDH.RemoveCurrent();
                bdsCTDDH.ResetCurrentItem(); //lấy dữ liệu đẩy lên lưới cập nhật những gì trên màn hình lên lưới
            }
        }

        private void btnGhi_CTDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn ghi chi tiết đơn đặt hàng?\nKhông thể thay đổi nội dung sau khi lưu", "Lưu ý", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

            try
            {
                bdsCTDDH.EndEdit();
                bdsCTDDH.ResetCurrentItem(); //lấy dữ liệu đẩy lên lưới cập nhật những gì trên màn hình lên lưới
                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;

                this.cTDDHTableAdapter.Update(this.DS.CTDDH);  //cập nhật vào database
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đơn hàng " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            gbTTCT_CTDDH.Enabled = btnGhi_CTDDH.Enabled = btnThem_CTDDH.Enabled = btnXoa_CTDDH.Enabled = btnHuy_CTDDH.Enabled = false;
            groupBox5.Enabled = true;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue == null) return;
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return; //Chưa chọn mà tự chạy thì kết thúc
            Program.servername = cmbChiNhanh.SelectedValue.ToString();  //chứa tên server mới
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepass;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)  //tạo lại chuỗi kết nối
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
                this.datHangTableAdapter.Fill(this.DS.DatHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsCTDDH.Count == 0) MessageBox.Show("Chưa có chi tiết đặt hàng, không thể nhập hàng!", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (Program.formPhieuNhap == null)
                {
                    Program.formPhieuNhap = new formPhieuNhap();
                    Program.formPhieuNhap.MdiParent = Program.formChinh;
                    Program.formPhieuNhap.Show();
                }
                else Program.formPhieuNhap.Activate();

                int vtPhieuNhap = Program.formPhieuNhap.bdsPhieuNhap.Find("MasoDDH", txtMaDDH.Text);    //Tim xem ma don dat hang da co o phieu nhap chua neu co thi tra ve vi tri >=0
                if (vtPhieuNhap >= 0) Program.formPhieuNhap.bdsPhieuNhap.Position = vtPhieuNhap;
                else
                {
                    // maDonDH = txtMaDDH.Text;
                    //maKho = txtMaKho.Text;
                    Program.formPhieuNhap.barButtonItem1_ItemClick_1(sender, e);
                    Program.formPhieuNhap.cbMaDDH.SelectedItem = txtMaDDH.Text.Trim();
                    //    Program.formPhieuNhap.cbMaDDH.SelectedIndex = 2;
                }
            }
        }

        private void formDatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formDatHang = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaVT_CTDDH.Text == "" || txtSoLuong_CTDDH.Text == "" || txtDonGia_CTDDH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtSoLuong_CTDDH.Value <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                txtSoLuong_CTDDH.Focus();
                return;
            }
            if (txtDonGia_CTDDH.Value <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                txtDonGia_CTDDH.Focus();
                return;
            }
            bdsCTDDH.EndEdit();
            gbTTCT_CTDDH.Enabled = false;
            btnThem_CTDDH.Enabled = btnXoa_CTDDH.Enabled = btnGhi_CTDDH.Enabled = groupBox6.Enabled = btnHuy_CTDDH.Enabled = true;

            btnThem_CTDDH.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bdsCTDDH.CancelEdit();
            gbTTCT_CTDDH.Enabled = false;
            btnThem_CTDDH.Enabled = btnXoa_CTDDH.Enabled = btnGhi_CTDDH.Enabled = groupBox6.Enabled = btnHuy_CTDDH.Enabled=  true;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (bdsCTDDH.Count == 0) btnThem_CTDDH.Enabled = true;
            else btnThem_CTDDH.Enabled = false;
        }


        private void btnHuy_CTDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chưa lưu chi tiết đặt hàng?\nHủy chi tiết đặt hàng", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

            try
            {
                this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
                bdsCTDDH.CancelEdit();
                gbTTCT_CTDDH.Enabled = btnHuy_CTDDH.Enabled = btnXoa_CTDDH.Enabled = btnGhi_CTDDH.Enabled = false;
                btnThem_CTDDH.Enabled = groupBox5.Enabled = groupBox6.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hủy không thành công :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cbxVatTu_CTDDH1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vt = cbxVatTu_CTDDH1.SelectedIndex;
            txtMaVT_CTDDH.Text = listVatTuChuaDat.ElementAt(vt).Key;
        }

        private void btnCancel_PN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy đơn đặt hàng", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

            bdsDatHang.CancelEdit();
            bdsDatHang.RemoveCurrent();
            gbTTDDH.Enabled = btnGhi.Enabled = btnThem_CTDDH.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnThem_CTDDH.Enabled = btnRefresh.Enabled = btnNhapHang.Enabled = groupBox6.Enabled = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (Program.mGroup == "CONGTY") return;
            if (bdsCTDDH.Count == 0) btnThem_CTDDH.Enabled = true;
            else btnThem_CTDDH.Enabled = false;
        }
    }
}
