using DevExpress.XtraReports.UI;
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
    public partial class formHoatDongNhanVien : Form
    {
        public formHoatDongNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void nhanVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void nhanVienBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formHoatDongNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            rdHangNhap.Checked = true;

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
            }
            else cmbChiNhanh.Enabled = false;

            if(bdsNhanVien.Count==0)
            {
                MessageBox.Show("Danh sách nhân viên rỗng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            for(int i=0; i<bdsNhanVien.Count; i++)
            {
                cbMaNV.Items.Add(((DataRowView)bdsNhanVien[i])["MANV"]);
            }
            cbMaNV.SelectedIndex = 0;
            txtNgayKetThuc.MinDate = txtNgayBatDau.Value.AddDays(1);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.rptHoatDongNhanXuatNhanVien rptHoatDongNhanXuatNhanVien;
            if (rdHangNhap.Checked)
                rptHoatDongNhanXuatNhanVien = new Report.rptHoatDongNhanXuatNhanVien(1, txtNgayBatDau.Value, txtNgayKetThuc.Value, int.Parse(cbMaNV.Text.Trim()));
            else
                rptHoatDongNhanXuatNhanVien = new Report.rptHoatDongNhanXuatNhanVien(0, txtNgayBatDau.Value, txtNgayKetThuc.Value, int.Parse(cbMaNV.Text.Trim()));

            rptHoatDongNhanXuatNhanVien.txtHoTenNV.Text = txtTenNV.Text;
            rptHoatDongNhanXuatNhanVien.txtMaNV.Text = cbMaNV.Text;
            rptHoatDongNhanXuatNhanVien.txtMaCN.Text = cmbChiNhanh.Text;
            DataRowView tro = ((DataRowView)bdsNhanVien[bdsNhanVien.Find("MANV", cbMaNV.Text)]);
            rptHoatDongNhanXuatNhanVien.txtNgaySinh.Text = tro["NGAYSINH"].ToString();
            rptHoatDongNhanXuatNhanVien.txtLuong.Text = tro["LUONG"].ToString();
            rptHoatDongNhanXuatNhanVien.txtDiaChi.Text = tro["DIACHI"].ToString();

            ReportPrintTool report = new ReportPrintTool(rptHoatDongNhanXuatNhanVien);
            report.ShowPreviewDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.FillBy(this.DS.NhanVien);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbMaNV.Text);
            DataRowView tro = (DataRowView)bdsNhanVien[bdsNhanVien.Find("MANV", cbMaNV.Text)];
            txtTenNV.Text = tro["HO"] + " " + tro["TEN"];
        }

        private void txtNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
           // txtNgayKetThuc.MinDate = txtNgayBatDau.Value;
        }

        private void txtNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            txtNgayKetThuc.MinDate = txtNgayBatDau.Value.AddDays(1);
        }
    }
}
