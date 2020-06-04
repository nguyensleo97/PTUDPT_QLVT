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
    public partial class formKho : Form
    {
        string macn = "";
        string maKho = null;
        public formKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void khoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void formKho_Load(object sender, EventArgs e)
        {
             dS.EnforceConstraints = false;  //không kiểm tra ràng buộc khóa ngoại nữa
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);

            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dS.DatHang);


            macn = ((DataRowView)bdsKho[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnRefresh.Enabled = false;
                cmbChiNhanh.Enabled = true;
            }
            else cmbChiNhanh.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue == null) return;
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return; //Chưa chọn mà tự chạy thì kết thúc
            if (bdsKho.Count <= 0) return;
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
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.dS.Kho);

                macn = ((DataRowView)bdsKho[0])["MACN"].ToString();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKho.AddNew();
            txtMaCN.Text = macn;
            groupBox1.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = khoGridControl.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maKho = txtMaKho.Text.Trim();
            txtMaKho.Enabled = false;
            groupBox1.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = khoGridControl.Enabled = btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được thiếu!", "", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return;
            }
            if (txtTenKho.Text.Trim() == "")
            {
                MessageBox.Show("Tên kho không được thiếu!", "", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu!", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }
            if (!txtMaKho.Text.Trim().Equals(maKho) || maKho == null)
            {
                try
                {
                    //Kiểm tra ma kho xem có bị trùng ko
                    String lenh = "EXEC [sp_KTMaKho] '" + txtMaKho.Text.Trim() + "'";
                    SqlDataReader kt = Program.ExecSqlDataReader(lenh);
                    if (kt == null) return;
                    kt.Read();
                    int i = (int)kt.GetInt32(0);
                    kt.Close();
                    if (i != 0)
                    {
                        MessageBox.Show("Mã kho bị trùng !", "", MessageBoxButtons.OK);
                        if (maKho != null) txtMaKho.Text = maKho;
                        txtMaKho.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kiểm tra mã kho " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }


            try
            {
                bdsKho.EndEdit();
                bdsKho.ResetCurrentItem(); //lấy dữ liệu đẩy lên lưới cập nhật những gì trên màn hình lên lưới
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;

                this.khoTableAdapter.Update(this.dS.Kho);  //cập nhật vào database
                maKho = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Kho: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = btnRefresh.Enabled = khoGridControl.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = groupBox1.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.dS.Kho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload kho", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maKho = ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString();
            if (bdsDatHang.Count > 0) MessageBox.Show("Kho đã được sử dụng, không thể xóa !", "Báo lỗi", MessageBoxButtons.OK);
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa kho này", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bdsKho.RemoveCurrent();
                    try
                    {
                        this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khoTableAdapter.Update(this.dS.Kho);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa vật tư, bạn hãy xóa lại\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        this.khoTableAdapter.Fill(this.dS.Kho);
                        bdsKho.Position = bdsKho.Find("MAKHO", maKho);
                        return;
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);
            groupBox1.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = btnRefresh.Enabled = khoGridControl.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false; 

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKho.CancelEdit();
            groupBox1.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled= false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = btnRefresh.Enabled = khoGridControl.Enabled = true;

        }

        private void khoGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
