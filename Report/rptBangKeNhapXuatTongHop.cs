using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.Report
{
    public partial class rptBangKeNhapXuatTongHop : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangKeNhapXuatTongHop(int congTy, int phieuNhap, DateTime ngayBD, DateTime ngayKT)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_BanKeNhapXuatTongHopTableAdapter1.Fill(ds1.sp_BanKeNhapXuatTongHop, congTy, phieuNhap, ngayBD, ngayKT);
        }

    }
}
