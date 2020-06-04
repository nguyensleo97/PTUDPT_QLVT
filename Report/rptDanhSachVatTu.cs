using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.Report
{
    public partial class rptDanhSachVatTu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachVatTu()
        {
            InitializeComponent();
            sp_DanhMucVatTuTableAdapter1.Connection.ConnectionString = Program.connstr;
            sp_DanhMucVatTuTableAdapter1.Fill(ds1.sp_DanhMucVatTu);
        }

    }
}
