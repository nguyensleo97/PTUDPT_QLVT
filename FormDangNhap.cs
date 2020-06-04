using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtLogin.Text = "TT";
            txtPass.Text = "123456";
            // TODO: This line of code loads data into the 'qLVTDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVTDataSet.V_DS_PHANMANH);
            tENCNComboBox.SelectedIndex = 1;
            tENCNComboBox.SelectedIndex = 0;
        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tENCNComboBox.SelectedValue!=null)
            Program.servername = tENCNComboBox.SelectedValue.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim()=="")
            {
                MessageBox.Show("Tài khoản đăng nhập không thành công", "Báo lỗi đăng nhập",MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;
            //MessageBox.Show("Đăng nhập thành công", " ", MessageBoxButtons.OK);

            
            Program.mChiNhanh = tENCNComboBox.SelectedIndex;
            Program.bds_dspm = bdsDSPM;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
          

            string strLenh = "EXEC DangNhap '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            //MessageBox.Show(Program.myReader.GetString(1));

            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoTen = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            //Program.conn.Close();

            Program.formChinh.MANV.Text = "Mã nhân viên: " + Program.username;
            Program.formChinh.HOTEN.Text = "Họ tên: " + Program.mHoTen;
            Program.formChinh.NHOM.Text = "Nhóm: " + Program.mGroup;

            Program.formChinh.ribbonDanhMuc.Visible = true;
            Program.formChinh.ribbonChucNang.Visible = true;
            Program.formChinh.ribbonBaoCao.Visible = true;

            Program.formDangNhap.tENCNComboBox.Enabled = Program.formDangNhap.tENCNComboBox.Enabled = Program.formDangNhap.btnDangNhap.Enabled = false;

            frmNhanVien f = new frmNhanVien();
            f.MdiParent = Program.formChinh;
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.formChinh.MANV.Text = "";
            Program.formChinh.HOTEN.Text = "";
            Program.formChinh.NHOM.Text = "";
            Program.formChinh.ribbonDanhMuc.Visible = false;
            Program.formChinh.ribbonChucNang.Visible = false;
            btnDangNhap.Enabled = tENCNComboBox.Enabled = true;

            Program.formChinh.closeAll();
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPass.Focus();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap_Click(sender, e);
        }
    }
}
