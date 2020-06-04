using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT.Report
{
    public partial class rptHoatDongNhanXuatNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHoatDongNhanXuatNhanVien(int nhaphang, DateTime ngayBD, DateTime ngayKT, int maNV)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_HoatDongNhanVienTableAdapter1.Fill(ds1.sp_HoatDongNhanVien, nhaphang, ngayBD, ngayKT, maNV);
        }

    }
}
