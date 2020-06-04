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
    public partial class formPhieuXuat : Form
    {
        int soLuongTon;
        public formPhieuXuat()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuXuat.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formXuatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            // TODO: This line of code loads data into the 'DS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.DS.CTPX);

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnThem_CTPN.Enabled = btnGhi_CTPN.Enabled = false;
                cmbChiNhanh.Enabled = true;
            }
            else cmbChiNhanh.Enabled = btnGhi.Enabled = btnGhi_CTPN.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            this.cTPXTableAdapter.Fill(this.DS.CTPX);

            bdsPhieuXuat.AddNew();
            txtMaNV.Text = Program.username;
            txtMaPX.Text = Program.getMaPX();
            txtNgay.Value = DateTime.Now;
            txtMaKho.Text = cbMaKho.SelectedValue.ToString().Trim();

            btnGhi.Enabled = groupBox4.Enabled = true;
            txtMaNV.Enabled = btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = phieuXuatGridControl.Enabled = groupBox2.Enabled = groupBox5.Enabled = false;
        }

        private void cbMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaKho.SelectedValue != null)
                txtMaKho.Text = cbMaKho.SelectedValue.ToString().Trim();
        }

        private void btnCancel_PN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy phiếu xuất", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

            bdsPhieuXuat.RemoveCurrent();
            groupBox2.Enabled = phieuXuatGridControl.Enabled = btnThem.Enabled = btnXoa.Enabled = true;
            groupBox4.Enabled = btnGhi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsChiTietPhieuXuat.Count > 0) MessageBox.Show("Đã tồn tại chi tiết phiếu xuất, không thể xóa !", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (MessageBox.Show("Bạn thực sự muốn xóa phiếu xuất", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        bdsPhieuXuat.RemoveCurrent();
                        bdsPhieuXuat.ResetCurrentItem();
                        this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuXuatTableAdapter.Update(this.DS.PhieuXuat);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa phiếu xuất " + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtHoTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu nhập không được thiếu!", "", MessageBoxButtons.OK);
                txtHoTenKH.Focus();
                return;
            }

            if (txtMaPX.Text.Length < 2 || !txtMaPX.Text.Trim().Substring(0, 2).Equals("PX"))
            {
                MessageBox.Show("Mã phiếu xuất phải đúng định dạng PXxxxxxx", "Thông báo", MessageBoxButtons.OK);
                txtMaPX.Text = Program.getMaPX().ToString();
                return;
            }
            try
            {
                //Kiểm tra pheiu xuat xem có bị trùng ko
                String lenh = "EXEC [sp_KTMaPX] '" + txtMaPX.Text.Trim() + "'";
                SqlDataReader kt = Program.ExecSqlDataReader(lenh);
                if (kt == null) return;
                kt.Read();
                int i = (int)kt.GetInt32(0);
                kt.Close();
                if (i != 0)
                {
                    MessageBox.Show("Mã phiếu xuất bị trùng !", "", MessageBoxButtons.OK);
                    txtMaPX.Text = Program.getMaPX().ToString();
                    return;
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                bdsPhieuXuat.EndEdit();
                bdsPhieuXuat.ResetCurrentItem();
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Update(this.DS.PhieuXuat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi phiếu xuất: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            phieuXuatGridControl.Enabled = groupBox2.Enabled = btnThem.Enabled = btnXoa.Enabled = true;
            groupBox4.Enabled = btnGhi.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThem_CTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //load lai vat tu
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            cbMaVT_CTPX.Items.Clear();
            for (int i = 0; i < bdsVatTu.Count; i++)
            {
                DataRowView tro = (DataRowView)bdsVatTu[i];
                if (tro["SOLUONGTON"].ToString() == "0") continue;
                cbMaVT_CTPX.Items.Add(new ComboboxItem { Text = tro["TENVT"].ToString(), Value = tro["MAVT"].ToString(), SoLuongTon = (int)tro["SOLUONGTON"] });
            }
            for (int i = 0; i < bdsChiTietPhieuXuat.Count; i++)
            {
                DataRowView tro = (DataRowView)bdsChiTietPhieuXuat[i];
                for (int j = 0; j < cbMaVT_CTPX.Items.Count; j++)
                    if (((ComboboxItem)cbMaVT_CTPX.Items[j]).Value == tro["MAVT"].ToString())
                    {
                        cbMaVT_CTPX.Items.RemoveAt(j);
                        j--;
                    }
            }
            if (cbMaVT_CTPX.Items.Count == 0)
            {
                MessageBox.Show("Không còn vật tư nào để xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            groupBox5.Enabled = true;
            bdsChiTietPhieuXuat.AddNew();

            groupBox1.Enabled = groupBox2.Enabled = groupBox4.Enabled = btnThem_CTPN.Enabled = false;
            cbMaVT_CTPX.SelectedIndex = 0;

            txtSoLuong_CTPX.Value = 0;
            txtDonGia_CTPX.Value = 0;
            ((DataRowView)bdsChiTietPhieuXuat[bdsChiTietPhieuXuat.Position])["DONGIA"] = 0;
            ((DataRowView)bdsChiTietPhieuXuat[bdsChiTietPhieuXuat.Position])["SOLUONG"] = 0;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (Program.mGroup == "CONGTY") return;
            if (bdsChiTietPhieuXuat.Count > 0) btnThem_CTPN.Enabled = false;
            else btnThem_CTPN.Enabled = true;
        }

        private void cbMaVT_CTPX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem tro = (ComboboxItem)cbMaVT_CTPX.SelectedItem;
            soLuongTon = tro.SoLuongTon;
            lbThongTinVT.Text = "Còn tồn " + soLuongTon + " " + tro.Text;
            txtMaVT_CTPX.Text = tro.Value.ToString();
            txtSoLuong_CTPX.Maximum = soLuongTon;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSoLuong_CTPX.Text == "" || txtDonGia_CTPX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtSoLuong_CTPX.Value <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                txtSoLuong_CTPX.Focus();
                return;
            }
            if (txtDonGia_CTPX.Value < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                txtDonGia_CTPX.Focus();
                return;
            }

            bdsChiTietPhieuXuat.EndEdit();
            groupBox5.Enabled = false;
            btnThem_CTPN.Enabled = btnXoa_CTPN.Enabled = btnGhi_CTPN.Enabled = groupBox2.Enabled = btnHuy_CTPN.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //bdsChiTietPhieuXuat.CancelEdit();
            bdsChiTietPhieuXuat.RemoveCurrent();
            groupBox5.Enabled = false;
            btnThem_CTPN.Enabled = btnXoa_CTPN.Enabled = btnGhi_CTPN.Enabled = groupBox2.Enabled = btnHuy_CTPN.Enabled = true;
        }

        private void btnXoa_CTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa vật tư này?", "Lưu ý", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bdsChiTietPhieuXuat.RemoveCurrent();
                bdsChiTietPhieuXuat.ResetCurrentItem(); //lấy dữ liệu đẩy lên lưới cập nhật những gì trên màn hình lên lưới
            }
        }

        private void btnHuy_CTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chưa lưu chi tiết phiếu xuất?\nHủy chi tiết phiếu xuất", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

            try
            {
                this.cTPXTableAdapter.Fill(this.DS.CTPX);
                groupBox1.Enabled = true;
                btnXoa_CTPN.Enabled = btnGhi_CTPN.Enabled = btnHuy_CTPN.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnGhi_CTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn ghi chi tiết phiếu xuất không?\nKhông thể thay đổi nội dung sau khi lưu", "Lưu ý", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            try
            {
                //bdsCTDDH.EndEdit();
                bdsChiTietPhieuXuat.ResetCurrentItem(); //lấy dữ liệu đẩy lên lưới cập nhật những gì trên màn hình lên lưới

                SqlTransaction sqlTransaction;
                vattuTableAdapter.Connection = Program.conn;
                sqlTransaction = vattuTableAdapter.Connection.BeginTransaction(IsolationLevel.Serializable);
                vattuTableAdapter.Adapter.SelectCommand.Transaction = sqlTransaction;
                vattuTableAdapter.Adapter.UpdateCommand.Transaction = sqlTransaction;
                vattuTableAdapter.Adapter.InsertCommand.Transaction = sqlTransaction;
                vattuTableAdapter.Adapter.DeleteCommand.Transaction = sqlTransaction;

                string maVT;
                try
                {
                    vattuTableAdapter.Fill(this.DS.Vattu);
                    
                    for (int i = 0; i < bdsChiTietPhieuXuat.Count; i++)
                    {
                        maVT = ((DataRowView)bdsChiTietPhieuXuat[i])["MAVT"].ToString().Trim();
                        this.DS.Vattu.FindByMAVT(maVT).SOLUONGTON -= (int)((DataRowView)bdsChiTietPhieuXuat[i])["SOLUONG"];
                    }
                    //Thread.Sleep(10000);
                    this.vattuTableAdapter.Update(this.DS.Vattu);
                    sqlTransaction.Commit();
                }
                catch (SqlException ex)
                {
                    sqlTransaction.Rollback();
                }

                this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPXTableAdapter.Update(this.DS.CTPX);  //cập nhật vào database
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đơn hàng " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            groupBox1.Enabled = true;
            btnXoa_CTPN.Enabled = btnGhi_CTPN.Enabled = btnHuy_CTPN.Enabled = false;
        }

        private void txtSoLuong_CTPX_KeyUp(object sender, KeyEventArgs e)
        {

            //MessageBox.Show(txtDonGia_CTPX.tx.ToString());
        }

        private void txtSoLuong_CTPX_Move(object sender, EventArgs e)
        {
            MessageBox.Show(txtDonGia_CTPX.Value.ToString());
        }
    }

}
