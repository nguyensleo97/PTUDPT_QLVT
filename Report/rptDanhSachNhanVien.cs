using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.Report
{
    public partial class rptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachNhanVien()
        {
            InitializeComponent();
            sp_DanhSachNhanVienTableAdapter1.Connection.ConnectionString = Program.connstr;
            sp_DanhSachNhanVienTableAdapter1.Fill(ds1.sp_DanhSachNhanVien);
        }

    }
}
