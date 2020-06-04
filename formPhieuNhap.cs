using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QLVT
{
    public partial class formPhieuNhap : Form
    {
        Dictionary<string, int> vatTuDaNhap = null;
        int vt;
        public formPhieuNhap()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuNhap.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);

            // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            // TODO: This line of code loads data into the 'DS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.DS.CTPN);

            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            //--------------
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnThem_CTPN.Enabled = btnGhi_CTPN.Enabled = false;
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = btnGhi.Enabled = btnGhi_CTPN.Enabled = false;
            }
        }


        public void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            this.cTPNTableAdapter.Fill(this.DS.CTPN);
            //Load lai Dat hang va chi tiet dat hang     vi phai cap nhat nhung don hang vua dat o form dat hang
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            //Phai xoa bo loc chi tiet dat hang  vi luc nhap chi tiet phieu nhap co gan bo loc
            bdsChiTietDatHang.RemoveFilter();
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);

            cbMaDDH.Items.Clear();
            //Load ra nhung don dat hang chua nhap vao combo box cbMaDDH
            string maSoDDH = "";
            
            for (int i = 0; i < bdsDatHang.Count; i++)
            {

                bdsDatHang.Position = i;
                maSoDDH = ((DataRowView)bdsDatHang[i])["MasoDDH"].ToString().Trim();
                //MessageBox.Show(bdsChiTietDatHang.Count.ToString());


                //MessageBox.Show(maSoDDH + " " + bdsChiTietDatHang.Find("MasoDDH", maSoDDH));
                if (bdsChiTietDatHang.Find("MasoDDH", maSoDDH) >= 0)
                {


                    cbMaDDH.Items.Add(maSoDDH);   //neu tim thay ma so ddh trong chi tiet dat hang (tuc chi tiet ko rong)

                }
            }
            for (int i = 0; i < bdsPhieuNhap.Count; i++)
                cbMaDDH.Items.Remove(((DataRowView)bdsPhieuNhap[i])["MasoDDH"].ToString().Trim());
            if (cbMaDDH.Items.Count == 0)
            {
                MessageBox.Show("Tất cả các đơn đặt hàng đã tồn tại ở phiếu nhập! ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            btnThem.Enabled = btnXoa.Enabled = groupBox2.Enabled = false;
            btnGhi.Enabled = groupBox4.Enabled = true;
            bdsPhieuNhap.AddNew();

            txtNgay.Value = DateTime.Now;
            txtMaNV.Text = Program.username;
            //txtMaKho.Text         duoc cap nhat luc select combobox change... tuc cbx>0 neu bang 0 thi tat ca don hang duoc nhap

            cbMaDDH.SelectedIndex = 0;
            txtMaPN.Text = "PN" + cbMaDDH.Text.Trim().Substring(4);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPN.Count > 0) MessageBox.Show("Đã tồn tại chi tiết phiếu nhập, không thể xóa !", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (MessageBox.Show("Bạn thực sự muốn xóa phiếu nhập", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        bdsPhieuNhap.RemoveCurrent();
                        bdsPhieuNhap.ResetCurrentItem();
                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.phieuNhapTableAdapter.Update(this.DS.PhieuNhap);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa phiếu nhập " + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaPN.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu nhập không được thiếu!", "", MessageBoxButtons.OK);
                txtMaPN.Focus();
                return;
            }
            try
            {
                bdsPhieuNhap.EndEdit();
                bdsPhieuNhap.ResetCurrentItem();
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Update(this.DS.PhieuNhap);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi phiếu nhập: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnXoa.Enabled = groupBox2.Enabled = true;
            groupBox4.Enabled = btnGhi.Enabled = false;
        }

        private void btnThem_CTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DataTable dt = new DataTable();
            cbTenVatTuChuaNhap.Items.Clear();
            String maDHDuocChon = txtMaDDH.Text;
            bdsChiTietDatHang.Filter = "MasoDDH = '" + maDHDuocChon + "'";

            DataRowView tro = null;
            int countVTDatHang = bdsChiTietDatHang.Count;
            if (bdsCTPN.Count == 0)
            {
                for (int i = 0; i <= countVTDatHang; i++) gridView2.AddNewRow();
                for (int i = 0; i < countVTDatHang; i++)
                {
                    //gridView2.AddNewRow();
                    tro = (DataRowView)bdsChiTietDatHang[i];
                    gridView2.SetRowCellValue(i, gridView2.Columns[1], tro["MAVT"]);
                    gridView2.SetRowCellValue(i, gridView2.Columns[2], tro["SOLUONG"]);
                    gridView2.SetRowCellValue(i, gridView2.Columns[3], tro["DONGIA"]);
                }
                bdsCTPN.RemoveAt(countVTDatHang);
                btnThem_CTPN.Enabled = btnXoa_CTPN.Enabled = btnGhi_CTPN.Enabled = btnHuy.Enabled = true;
                groupBox1.Enabled = groupBox4.Enabled = false;
                colSOLUONG.OptionsColumn.AllowEdit = colDONGIA.OptionsColumn.AllowEdit = true;
                return;

            }
            vatTuDaNhap = new Dictionary<string, int>();

            //Them nhung vat tu da dat hang va so luong vao Dictionary
            for (int i = 0; i < countVTDatHang; i++)
            {
                tro = (DataRowView)bdsChiTietDatHang[i];
                vatTuDaNhap.Add(tro["MAVT"].ToString().Trim(), (int)tro["SOLUONG"]);
                // Message bdsChiTietDatHang[i].ToString();
            }

            int countVTDaNhap = bdsCTPN.Count;
            //Hieu bo vat tu da dat nhap va so luong
            for (int i = 0; i < countVTDaNhap; i++)
            {
                tro = (DataRowView)bdsCTPN[i];
                vatTuDaNhap.Remove(tro["MAVT"].ToString().Trim());                      //khong cho hien ra nua
                                                                                        //vatTuDaNhap[tro["MAVT"].ToString().Trim()] -= (int)tro["SOLUONG"];    //    chi hieu so luong
            }

            //Dua dictionary vao combobox
            for (int i = 0; i < vatTuDaNhap.Count; i++)
            {
                KeyValuePair<String, int> keyValuePair = vatTuDaNhap.ElementAt(i);
                if (keyValuePair.Value != 0)
                {
                    int vt = bdsVatTu.Find("MAVT", keyValuePair.Key);
                    cbTenVatTuChuaNhap.Items.Add(((DataRowView)bdsVatTu[vt])["TENVT"].ToString());  //Them ten vat tu chua nhap vao cbMaVTChuaNhap
                }
                else
                {
                    vatTuDaNhap.Remove(keyValuePair.Key);
                    i--;
                }
            }


            if (vatTuDaNhap.Count == 0)
            {
                MessageBox.Show("Tất cả vật tư đã được nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            groupBox5.Enabled = true;
            bdsCTPN.AddNew();

            groupBox1.Enabled = groupBox4.Enabled = btnThem_CTPN.Enabled = false;
            cbTenVatTuChuaNhap.SelectedIndex = 0;
            txtDonGia_CTPN.Value = 0;
            txtSoLuong_CTPN.Value = 0;
            ((DataRowView)bdsCTPN[bdsCTPN.Position])["DONGIA"] = 0;
            ((DataRowView)bdsCTPN[bdsCTPN.Position])["SOLUONG"] = 0;

        }

        /*
        private void btnThem_CTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbTenVatTuChuaNhap.Items.Clear();
            String maDHDuocChon = txtMaDDH.Text;
            bdsChiTietDatHang.Filter = "MasoDDH = '" + maDHDuocChon + "'";
            vatTuDaNhap = new Dictionary<string, int>();

            DataRowView tro = null;
            int countVTDatHang= bdsChiTietDatHang.Count;
            //Them nhung vat tu da dat hang va so luong vao Dictionary
            for (int i=0; i< countVTDatHang; i++)
            {
                tro = (DataRowView)bdsChiTietDatHang[i];
                vatTuDaNhap.Add(tro["MAVT"].ToString().Trim(), (int)tro["SOLUONG"]);
            }

            int countVTDaNhap = bdsCTPN.Count;
            //Hieu bo vat tu da dat nhap va so luong
            for (int i = 0; i < countVTDaNhap; i++)
            {
                tro = (DataRowView)bdsCTPN[i];
                vatTuDaNhap.Remove(tro["MAVT"].ToString().Trim());                      //khong cho hien ra nua
                //vatTuDaNhap[tro["MAVT"].ToString().Trim()] -= (int)tro["SOLUONG"];    //    chi hieu so luong
            }

            //Dua dictionary vao combobox
            for (int i=0; i< vatTuDaNhap.Count; i++)
            {
                KeyValuePair<String, int> keyValuePair = vatTuDaNhap.ElementAt(i);
                if (keyValuePair.Value != 0)
                {
                    int vt = bdsVatTu.Find("MAVT", keyValuePair.Key);
                    cbTenVatTuChuaNhap.Items.Add(((DataRowView)bdsVatTu[vt])["TENVT"].ToString());  //Them ten vat tu chua nhap vao cbMaVTChuaNhap
                }
                else
                {
                    vatTuDaNhap.Remove(keyValuePair.Key);
                    i--;
                }
            }
            if (vatTuDaNhap.Count == 0)
            {
                MessageBox.Show("Tất cả vật tư đã được nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            groupBox5.Enabled = true;
            bdsCTPN.AddNew();

            groupBox1.Enabled = groupBox4.Enabled = btnThem_CTPN.Enabled = false;
            cbTenVatTuChuaNhap.SelectedIndex = 0;

            //cbTenVatTuChuaNhap.SelectedIndex = 0;
            //txtMaPN_CTPN.Text = "SDF";// vatTuDaNhap.ElementAt(0).Key;

        }*/


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
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            }
        }

        private void formPhieuNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formPhieuNhap = null;
        }

        private void cbMaDDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaDDH.Text = cbMaDDH.Text.Trim();
            txtMaPN.Text = "PN" + cbMaDDH.Text.Trim().Substring(4);
            txtMaKho.Text = ((DataRowView)bdsDatHang[bdsDatHang.Find("MasoDDH", txtMaDDH.Text)])["MAKHO"].ToString().Trim();
        }


        private void cbMaVTChuaNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            String maVTDangChon = cbTenVatTuChuaNhap.Text;
            vt = cbTenVatTuChuaNhap.SelectedIndex;
            txtMaVT_CTPN.Text = vatTuDaNhap.ElementAt(vt).Key;
            lbThongTinVT.Text = "Còn " + vatTuDaNhap.ElementAt(vt).Value + " " + cbTenVatTuChuaNhap.Text + " chưa nhập hàng";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {



            if (txtSoLuong_CTPN.Text == "" || txtDonGia_CTPN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            //----------------------------------------
            if (txtSoLuong_CTPN.Value <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                txtSoLuong_CTPN.Focus();
                return;
            }
            if (txtDonGia_CTPN.Value < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                txtDonGia_CTPN.Focus();
                return;
            }
            if (int.Parse(txtSoLuong_CTPN.Text) > vatTuDaNhap.ElementAt(vt).Value)
            {
                MessageBox.Show("Vượt quá số lượng đã đặt!", "Báo lỗi", MessageBoxButtons.OK);
                return;
            }


            bdsCTPN.EndEdit();
            groupBox5.Enabled = false;
            btnThem_CTPN.Enabled = btnXoa_CTPN.Enabled = btnGhi_CTPN.Enabled = groupBox2.Enabled = btnHuy.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //bdsCTPN.CancelEdit();
            bdsCTPN.RemoveCurrent();
            groupBox5.Enabled = false;
            btnThem_CTPN.Enabled = btnXoa_CTPN.Enabled = btnGhi_CTPN.Enabled = groupBox2.Enabled = btnHuy.Enabled = true;
        }

        private void btnRefresh1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.cTPNTableAdapter.Fill(this.DS.CTPN);
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn chưa lưu chi tiết phiếu nhập?\nHủy chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

            try
            {
                this.cTPNTableAdapter.Fill(this.DS.CTPN);
                groupBox1.Enabled = true;
                btnXoa_CTPN.Enabled = btnGhi_CTPN.Enabled = btnHuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_CTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa vật tư này?", "Lưu ý", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bdsCTPN.RemoveCurrent();
                bdsCTPN.ResetCurrentItem(); //lấy dữ liệu đẩy lên lưới cập nhật những gì trên màn hình lên lưới
            }
        }

        private void btnGhi_CTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView2.CloseEditor();
            int soLuong;
            double donGia;
            for(int i=0;i<gridView2.RowCount; i++)
            {
                soLuong = (int) gridView2.GetRowCellValue(i, gridView2.Columns[2]);
                donGia = (double)gridView2.GetRowCellValue(i, gridView2.Columns[3]);
                if (soLuong <= 0 || donGia < 0)
                {
                    MessageBox.Show("Dữ liệu nhập sai tại dòng " + (i + 1));
                    gridView2.FocusedRowHandle = i;
                    
                    return;
                }
            }
            if (MessageBox.Show("Bạn thực sự muốn ghi chi tiết phiếu nhập?\nKhông thể thay đổi nội dung sau khi lưu", "Lưu ý", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            try
            {
                bdsCTPN.EndEdit();
                bdsCTPN.ResetCurrentItem(); //lấy dữ liệu đẩy lên lưới cập nhật những gì trên màn hình lên lưới

                vattuTableAdapter.Fill(this.DS.Vattu);
                string maVT;
                for (int i = 0; i < bdsCTPN.Count; i++)
                {
                    maVT = ((DataRowView)bdsCTPN[i])["MAVT"].ToString().Trim();
                    this.DS.Vattu.FindByMAVT(maVT).SOLUONGTON += (int)((DataRowView)bdsCTPN[i])["SOLUONG"];
                }
                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Update(this.DS.Vattu);

                this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPNTableAdapter.Update(this.DS.CTPN);  //cập nhật vào database
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đơn hàng " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            colSOLUONG.OptionsColumn.AllowEdit = colDONGIA.OptionsColumn.AllowEdit = false;
            btnThem_CTPN.Enabled = btnXoa_CTPN.Enabled = btnGhi_CTPN.Enabled = btnHuy.Enabled = false;
            groupBox1.Enabled = true;
        }
        /*
        private void btnGhi_CTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn thực sự muốn ghi chi tiết phiếu nhập?\nKhông thể thay đổi nội dung sau khi lưu", "Lưu ý", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            SqlTransaction sqlTransaction;
            try
            {
                txtSoLuong_CTPN.Focus();
                //bdsCTPN.EndEdit();
                bdsCTPN.ResetCurrentItem(); //lấy dữ liệu đẩy lên lưới cập nhật những gì trên màn hình lên lưới

                cTPNTableAdapter.Connection = Program.conn;
                sqlTransaction = cTPNTableAdapter.Connection.BeginTransaction(IsolationLevel.Serializable);
                cTPNTableAdapter.Adapter.SelectCommand.Transaction = sqlTransaction;
                cTPNTableAdapter.Adapter.UpdateCommand.Transaction = sqlTransaction;
                cTPNTableAdapter.Adapter.InsertCommand.Transaction = sqlTransaction;
                cTPNTableAdapter.Adapter.DeleteCommand.Transaction = sqlTransaction;
                try
                {
                    this.cTPNTableAdapter.Update(this.DS.CTPN);  //cập nhật vào database
                    sqlTransaction.Commit();
                }
                catch (SqlException ex)
                {
                    sqlTransaction.Rollback();
                    MessageBox.Show("Dữ liệu không hợp lệ");
                    btnThem_CTPN.Enabled = btnXoa_CTPN.Enabled = btnGhi_CTPN.Enabled = btnHuy.Enabled = true;
                    groupBox1.Enabled = groupBox4.Enabled = false;
                    colSOLUONG.OptionsColumn.AllowEdit = colDONGIA.OptionsColumn.AllowEdit = true;
                    //sqlTransaction.
                    //cTPNTableAdapter.Connection.Close();
                    return;
                }

                vattuTableAdapter.Connection = Program.conn;
                sqlTransaction = vattuTableAdapter.Connection.BeginTransaction(IsolationLevel.Serializable);
                vattuTableAdapter.Adapter.SelectCommand.Transaction = sqlTransaction;
                vattuTableAdapter.Adapter.UpdateCommand.Transaction = sqlTransaction;
                vattuTableAdapter.Adapter.InsertCommand.Transaction = sqlTransaction;
                vattuTableAdapter.Adapter.DeleteCommand.Transaction = sqlTransaction;

                try
                {
                    vattuTableAdapter.Fill(this.DS.Vattu);
                    string maVT;
                    for (int i = 0; i < bdsCTPN.Count; i++)
                    {
                        maVT = ((DataRowView)bdsCTPN[i])["MAVT"].ToString().Trim();
                        this.DS.Vattu.FindByMAVT(maVT).SOLUONGTON += (int)((DataRowView)bdsCTPN[i])["SOLUONG"];
                    }
                    //this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                    //Thread.Sleep(10000);
                    this.vattuTableAdapter.Update(this.DS.Vattu);
                    sqlTransaction.Commit();
                }
                catch(SqlException ex)
                {
                    sqlTransaction.Rollback();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đơn hàng " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            colSOLUONG.OptionsColumn.AllowEdit = colDONGIA.OptionsColumn.AllowEdit = false;
            btnThem_CTPN.Enabled = btnXoa_CTPN.Enabled = btnGhi_CTPN.Enabled = btnHuy.Enabled = false;
            groupBox1.Enabled = true;
        }
        */
        private void btnCancel_PN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy phiếu nhập", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

            //bdsPhieuNhap.CancelEdit();
            bdsPhieuNhap.RemoveCurrent();
            btnThem.Enabled = btnXoa.Enabled = groupBox1.Enabled = groupBox2.Enabled = true;
            groupBox4.Enabled = btnGhi.Enabled = false;
        }

        private void cmbChiNhanh_SelectedIndexChanged_1(object sender, EventArgs e)
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
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (Program.mGroup == "CONGTY") return;
            if (bdsCTPN.Count > 0) btnThem_CTPN.Enabled = false;
            else btnThem_CTPN.Enabled = true;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.formDatHang == null)
            {
                Program.formDatHang = new formDatHang();
                Program.formDatHang.MdiParent = Program.formChinh;
                Program.formDatHang.Show();
            }
            else Program.formDatHang.Activate();

            int vtDH = Program.formDatHang.bdsDatHang.Find("MasoDDH", txtMaDDH.Text);    //Tim xem ma don dat hang da co o phieu nhap chua neu co thi tra ve vi tri >=0
            if (vtDH >= 0) Program.formDatHang.bdsDatHang.Position = vtDH;
        }
    }
}
