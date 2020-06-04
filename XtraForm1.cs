using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVT
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            DuAn duAn = new DuAn();
            duAn.ThuocTinh1 = "c01";
            duAn.ThuocTinh2 = "Nâng cấp hệ thống viễn thông";
            duAn.ThuocTinh3 = "SA.CO";
            duAn.ThuocTinh4 = "VL01";
            duAnBindingSource.Add(duAn);

            duAn = new DuAn();
            duAn.ThuocTinh1 = "c01";
            duAn.ThuocTinh2 = "Nâng cấp hệ thống viễn thông";
            duAn.ThuocTinh3 = "SA.CO";
            duAn.ThuocTinh4 = "VL01";

            duAnBindingSource.Add(duAn);
            duAn = new DuAn();
            duAn.ThuocTinh1 = "c02";
            duAn.ThuocTinh2 = "Hệ thống trung kế khu vực I";
            duAn.ThuocTinh3 = "VIC.CO";
            duAn.ThuocTinh4 = "NS02";

            duAnBindingSource.Add(duAn);
            duAn = new DuAn();
            duAn.ThuocTinh1 = "c03";
            duAn.ThuocTinh2 = "Cải tạo hệ thống chuyển tầng";
            duAn.ThuocTinh3 = "HN.LTD";
            duAn.ThuocTinh4 = "TD01";
            duAnBindingSource.Add(duAn);
            duAn = new DuAn();
            duAn.ThuocTinh1 = "c04";
            duAn.ThuocTinh2 = "Hệ thống phát sóng băng tần A";
            duAn.ThuocTinh3 = "HC.CO";
            duAn.ThuocTinh4 = "NS01";
            duAnBindingSource.Add(duAn);
            duAn = new DuAn();
            duAn.ThuocTinh1 = "c05";
            duAn.ThuocTinh2 = "Trung tâm điều hòa tín hiệu";
            duAn.ThuocTinh3 = "VN.LTD";
            duAn.ThuocTinh4 = "VL01";
            duAnBindingSource.Add(duAn);
            duAn = new DuAn();
            duAn.ThuocTinh1 = "c06";
            duAn.ThuocTinh2 = "Sở giao dịch trung tâm";
            duAn.ThuocTinh3 = "CA.CO";
            duAn.ThuocTinh4 = "VL02";
            duAnBindingSource.Add(duAn);

            txtMaDuAn.Text = "c01";
            txtChuDauTu.Text = "SA.CO";
            txtTenDuAn.Text = "Nâng cấp hệ thống viễn thông";
            txtMaNhomDA.Text = "VL01";

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = gvDuAn.Enabled = txtMaNhomDA.Enabled = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}