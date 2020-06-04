using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.Report
{
    public partial class rptDanhSachDatHangChuaNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachDatHangChuaNhap()
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            sp_DanhSachDonDatHangChuaNhapTableAdapter1.Connection.ConnectionString = Program.connstr;
            sp_DanhSachDonDatHangChuaNhapTableAdapter1.Fill(ds1.sp_DanhSachDonDatHangChuaNhap);
        }

    }
}
