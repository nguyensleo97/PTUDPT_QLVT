using DevExpress.XtraReports.UI;
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
    public partial class frmNhanVien : Form
    {
        int vitri = 0;
        string macn = "";
        string maNVCP = null;       //khi nhan vao nut them thi ma nv moi duoc cap phat
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int manv = 0;
            if(MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                if (bdsPN.Count > 0)
                {
                    txtTrangThaiXoa.EditValue = "1";
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem(); //lấy dữ liệu đẩy lên lưới cập nhật những gì trên màn hình lên lưới                       
                }
                else
                {
                    bdsNV.RemoveCurrent();
                }
                //update lên database
                try
                {                  
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên, bạn hãy xóa lại\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }
            if (bdsNV.Count == 0) btnXoa.Enabled = false;   //nếu không còn nhân viên nào hết thì ẩn nút xóa

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;  //không kiểm tra ràng buộc khóa ngoại nữa
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            // TODO: This line of code loads data into the 'DS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            macn = ((DataRowView)bdsNV[0])["MACN"].ToString(); 
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnChuyenChiNhanh.Enabled = false;
                cmbChiNhanh.Enabled = true;
            }
            else cmbChiNhanh.Enabled = btnXoa.Enabled = btnSua.Enabled = btnChuyenChiNhanh.Enabled = false;

        }

        private void tENTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue == null) return;
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return; //Chưa chọn mà tự chạy thì kết thúc
            if (bdsNV.Count <= 0) return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();  //chứa tên server mới
            if(cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

                macn = ((DataRowView)bdsNV[0])["MACN"].ToString(); // rẽ chi nhánh thì cập nhật mã mới 
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String MaNV = ((DataRowView)bdsNV[vitri])["MANV"].ToString().Trim();   //lấy mã nhân viên ở vị trí dòng đang đứng
            if (maNVCP != null) MaNV = maNVCP;
            // Kiểm tra thông tin đã hợp lệ chưa
            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }
            else if(!MaNV.Trim().Equals(txtMANV.Text.Trim()) && maNVCP==null || maNVCP!=null)     //nếu mã nv tại ô txtMANV khác với mã nv tại dòng đang xét thì kiểm tra
            {   
                //Kiểm tra mã nhân viên xem có bị trùng ko
                String lenh = "EXEC [TimNV] '" + txtMANV.Text.Trim() + "'";
                SqlDataReader kt = Program.ExecSqlDataReader(lenh);
                if (kt == null) return;
                kt.Read();
                int i = (int)kt.GetInt32(0);
                kt.Close();
                if (i!=0)
                {
                    MessageBox.Show("Mã nhân viên bị trùng!", "", MessageBoxButtons.OK);
                    if (maNVCP != null) MaNV = Program.getMaNV().ToString();
                    txtMANV.Text = MaNV;
                    return;
                }               
            }
            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtHO.Focus();
                return;
            }
            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }
            if (txtDIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }
            if (txtNGAYSINH.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }
            if (txtLUONG.Text.Trim() == "")
            {
                MessageBox.Show("Lương nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }
            else
            {
                double luong = double.Parse(txtLUONG.Text.Trim());
                if (luong < 4000000 || luong > 50000000)
                {
                    MessageBox.Show("Lương nhân viên không hợp lệ!", "", MessageBoxButtons.OK);
                    txtLUONG.Focus();
                    return;
                }
            }

            // MANV không được trùng trên các phân mảnh
            try
            {
                bdsNV.EndEdit();
                bdsNV.ResetCurrentItem(); //lấy dữ liệu đẩy lên lưới cập nhật những gì trên màn hình lên lưới
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
    
                this.nhanVienTableAdapter.Update(this.DS.NhanVien);  //cập nhật vào database
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên: " + ex.Message, "",MessageBoxButtons.OK);
                return;
            }
            maNVCP = null;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = btnRefresh.Enabled = nhanVienGridControl.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = groupBox1.Enabled = false;

        }

        private void bdsNV_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position; // poaition số thứ tự của mẫu tin đó trong ds nhân viên
            groupBox1.Enabled = true;
            bdsNV.AddNew();
            txtMANV.Text = maNVCP = Program.getMaNV().ToString();
            txtMACN.Text = macn;
            txtNGAYSINH.EditValue = "";
            txtTrangThaiXoa.EditValue = "0";

            btnThem.Enabled = btnPhucHoi.Enabled =btnChuyenChiNhanh.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = btnRefresh.Enabled = nhanVienGridControl.Enabled = btnTaoLogin.Enabled = btnINDSNV.Enabled = false;
            btnGhi.Enabled = true;
           
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = nhanVienGridControl.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            btnINDSNV.Enabled = btnTaoLogin.Enabled = false;
            txtMANV.Enabled = false;
            //gcNhanvien.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                btnSua.Enabled = btnXoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.Close();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            String ttx = ((DataRowView)bdsNV.Current)["TrangThaiXoa"].ToString();
            if (ttx == "1") btnXoa.Enabled = btnSua.Enabled = btnChuyenChiNhanh.Enabled = false;
            if (txtMANV.Text == Program.username) btnChuyenChiNhanh.Enabled = false;
            else btnXoa.Enabled = btnSua.Enabled = btnChuyenChiNhanh.Enabled = true;
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.rptDanhSachNhanVien rptDanhSachNhanVien = new Report.rptDanhSachNhanVien();
            ReportPrintTool report = new ReportPrintTool(rptDanhSachNhanVien);
            report.ShowPreviewDialog();
        }

        private void btnTaoLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTrangThaiXoa.Text.Equals("1"))
            {
                MessageBox.Show("Nhân viên đã xóa", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            formTaoLogin formTaoLogin = new formTaoLogin(Program.mGroup);
            formTaoLogin.ShowDialog();
            if(formTaoLogin.thongTinLogin != null)
            {
                string maNV = ((DataRowView)bdsNV.Current)["MANV"].ToString().Trim();
                formTaoLogin.thongTinLogin.UserName = maNV;
                bool kq = Program.taoLogin(formTaoLogin.thongTinLogin);
                if (kq)
                {
                        MessageBox.Show("Tạo Login thành công");
                        return;
                }
            }
            formTaoLogin.Close();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            btnThem.Enabled=btnSua.Enabled= btnChuyenChiNhanh.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = btnTaoLogin.Enabled = btnINDSNV.Enabled = true;
            nhanVienGridControl.Enabled = true;
        }

        private void btnChuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int maNVTimThay = Program.KiemTraTonTaiTaiKhoan(txtHO.Text, txtTEN.Text, txtDIACHI.Text, txtNGAYSINH.DateTime);
           // MessageBox.Show(maNVTimThay.ToString());
            if (maNVTimThay == -1)
            {
                formNhapMaNV formTHNX = new formNhapMaNV();
                formTHNX.txtMaNVCu.Text = txtMANV.Text;
                formTHNX.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chuyển nhân viên " + txtMANV.Text + " sang chi nhánh mới không", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
                Program.chuyenNV(int.Parse(txtMANV.Text), -1, maNVTimThay);
                MessageBox.Show("Chuyển nhân viên " + txtMANV.Text + " thành " + maNVTimThay);
                
            }
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            vitri = 1;
            btnThem.Enabled = btnSua.Enabled = btnChuyenChiNhanh.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = btnTaoLogin.Enabled = btnINDSNV.Enabled = true;
            nhanVienGridControl.Enabled = true;
            groupBox1.Enabled= btnGhi.Enabled = btnPhucHoi.Enabled = false; 
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
        }
    }
}
