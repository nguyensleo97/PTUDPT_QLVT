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
    public partial class formBangKetNhapXuat : Form
    {
        public formBangKetNhapXuat()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int congTy, hangNhap;
            if (Program.mGroup == "CONGTY") congTy = 1;
            else congTy = 0;
                if (rdHangNhap.Checked) hangNhap = 1;
            else hangNhap = 0;

           // MessageBox.Show("Hang Xuat " + txtNgayBatDau.Value + " " + txtNgayKetThuc.Value);

            Report.rptBangKeNhapXuatTongHop rptBangKeNhapXuat = new Report.rptBangKeNhapXuatTongHop(congTy, hangNhap, txtNgayBatDau.Value, txtNgayKetThuc.Value);
            ReportPrintTool report = new ReportPrintTool(rptBangKeNhapXuat);

            rptBangKeNhapXuat.xrLabel1.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ " + ((hangNhap==1)?"PHIẾU NHẬP":"PHIẾU XUẤT");

            report.ShowPreviewDialog();
        }

        private void formBangKetNhapXuat_Load(object sender, EventArgs e)
        {
            txtNgayKetThuc.MinDate = txtNgayBatDau.Value.AddDays(1);
            rdHangNhap.Checked = true;
        }

        private void txtNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            txtNgayKetThuc.MinDate = txtNgayBatDau.Value.AddDays(1);
        }
    }
}
