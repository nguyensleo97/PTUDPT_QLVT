using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.Report
{
    public partial class rptTongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTongHopNhapXuat(DateTime ngayBD, DateTime ngayKT)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_TongHopNhapXuatTableAdapter1.Fill(ds1.sp_TongHopNhapXuat, ngayBD, ngayKT);

        }

    }
}
