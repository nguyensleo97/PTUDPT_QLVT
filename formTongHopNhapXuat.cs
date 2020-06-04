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
    public partial class formTongHopNhapXuat : Form
    {
        public formTongHopNhapXuat()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.rptTongHopNhapXuat rptTongHopNhapXuat;
            rptTongHopNhapXuat = new Report.rptTongHopNhapXuat(txtNgayBatDau.Value, txtNgayKetThuc.Value);
            rptTongHopNhapXuat.txtThoiGian.Text = "TỪ " + txtNgayBatDau.Value +" ĐẾN " + txtNgayKetThuc.Value;
            ReportPrintTool report = new ReportPrintTool(rptTongHopNhapXuat);
            report.ShowPreviewDialog();
        }

        private void formTongHopNhapXuat_Load(object sender, EventArgs e)
        {
            txtNgayKetThuc.MinDate = txtNgayBatDau.Value.AddDays(1);
        }

        private void txtNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            txtNgayKetThuc.MinDate = txtNgayBatDau.Value.AddDays(1);
        }
    }
}
