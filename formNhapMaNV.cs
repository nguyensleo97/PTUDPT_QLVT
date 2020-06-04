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
    public partial class formNhapMaNV : Form
    {
        public formNhapMaNV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            //Kiểm tra mã nhân viên xem có bị trùng ko
            String lenh = "EXEC [TimNV] '" + txtMaNV.Text.Trim() + "'";
            SqlDataReader kt = Program.ExecSqlDataReader(lenh);
            if (kt == null) return;
            kt.Read();
            int i = (int)kt.GetInt32(0);
            kt.Close();
            if (i != 0)
            {
                MessageBox.Show("Mã nhân viên bị trùng!", "", MessageBoxButtons.OK);
                txtMaNV.Text = Program.getMaNV().ToString();
                return;
            }
            if (MessageBox.Show("Bạn có chắc chuyển nhân viên " + txtMaNVCu.Text + " sang chi nhánh mới không", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            Program.chuyenNV(int.Parse(txtMaNVCu.Text), (int)txtMaNV.Value, -1);
            MessageBox.Show("Đã chuyển nhân viên " + txtMaNVCu.Text + " thành " + txtMaNV.Value);
       
            this.Close();
        }

        private void formNhapMaNV_Load(object sender, EventArgs e)
        {
            txtMaNV.Value = Program.getMaNV();
        }
    }
}
