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
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
            Program.formDangNhap = new FormDangNhap();
            Program.formDangNhap.MdiParent = this;
            Program.formDangNhap.Show();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FormDangNhap f = new FormDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();

            }
        }

        private void barButtonItem1_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formVatTu));
            if (frm != null) frm.Activate();
            else
            {
                formVatTu f = new formVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick_3(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FormDangNhap f = new FormDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formKho));
            if (frm != null) frm.Activate();
            else
            {
                formKho f = new formKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void MANV_Click(object sender, EventArgs e)
        {

        }

        private void btnDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.formDatHang != null) Program.formDatHang.Activate();
            else
            {
                Program.formDatHang = new formDatHang();
                Program.formDatHang.MdiParent = this;
                Program.formDatHang.Show();
            }
        }

        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.formPhieuNhap == null)
            {
                Program.formPhieuNhap = new formPhieuNhap();
                Program.formPhieuNhap.MdiParent = Program.formChinh;
                Program.formPhieuNhap.Show();
            }
            else Program.formPhieuNhap.Activate();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

           
        }
        public void closeAll()
        {
        /*    FormCollection fc = Application.OpenForms;
            if (fc.Count > 1)
            {
                for (int i = (fc.Count); i > 1; i--)
                {
                    Form selectedForm = Application.OpenForms[i - 1];
                    if(selectedForm.Name != "formMain")
                        selectedForm.Close();
                }
            }*/

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "formMain" || Application.OpenForms[i].Name == "FormDangNhap") continue;
                    Application.OpenForms[i].Close();
            }
        }

        private void btnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                formPhieuXuat f = new formPhieuXuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDanhMucVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.rptDanhSachVatTu rptDanhSachVatTu = new Report.rptDanhSachVatTu();
            rptDanhSachVatTu.lbHoTen.Text = Program.mHoTen;
            ReportPrintTool report = new ReportPrintTool(rptDanhSachVatTu);
            report.ShowPreviewDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.rptDanhSachDatHangChuaNhap rptDSVTCN = new Report.rptDanhSachDatHangChuaNhap();
            ReportPrintTool report = new ReportPrintTool(rptDSVTCN);
            report.ShowPreviewDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formBangKetNhapXuat formBangKe = new formBangKetNhapXuat();
            formBangKe.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formHoatDongNhanVien formHDNV = new formHoatDongNhanVien();
            formHDNV.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formTongHopNhapXuat formTHNX = new formTongHopNhapXuat();
            formTHNX.ShowDialog();
        }

        private void btnThoat1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
 }
