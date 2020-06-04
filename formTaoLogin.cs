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
    public partial class formTaoLogin : Form
    {
        public ThongTinLogin thongTinLogin = null;
        public formTaoLogin(String Role)
        {
            InitializeComponent();
            if (string.Compare(Role, "CONGTY") == 0) cbNhom.Items.Add("CONGTY");
            if (string.Compare(Role, "CHINHANH") == 0)
            {
                cbNhom.Items.Add("CHINHANH");
                cbNhom.Items.Add("USER");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            thongTinLogin = new ThongTinLogin
            {
                Role = cbNhom.SelectedItem.ToString(),
                LoginName = txtTenLogin.Text.Trim(),
                Pass = txtPass.Text.Trim()
            };
            this.Hide();    //an form tao login
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thongTinLogin = null;
            this.Close();
        }

        private void cbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
