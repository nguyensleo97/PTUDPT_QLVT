using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT
{
    public partial class formVatTu : Form
    {
        //int vitri = 0;
        //bool themVT = false;
        string maVT = null;

        public formVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formVatTu_Load(object sender, EventArgs e)
        {
           
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
            if(Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            }
        }

        private void vattuBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tENVTTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)           
        {
            bdsVatTu.AddNew();
            groupBox1.Enabled = btnGhi.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = vattuGridControl.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maVT = txtMaVT.Text.Trim();
            txtMaVT.Enabled = false;
            groupBox1.Enabled = btnGhi.Enabled = true;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = vattuGridControl.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được thiếu!", "", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return;
            }
            else if(!txtMaVT.Text.Trim().Equals(maVT) || maVT == null)
            {
                String query = "EXEC dbo.TimMaVT @MAVT = '" + txtMaVT.Text.Trim() + "'";
                SqlDataReader kt = Program.ExecSqlDataReader(query);
                if (kt == null) return;
                kt.Read();
                int i = (int)kt.GetInt32(0);
                kt.Close();
                if (i != 0)
                {
                    MessageBox.Show("Mã vật tư bị trùng!", "", MessageBoxButtons.OK);
                    if (maVT!=null) txtMaVT.Text = maVT;
                    txtMaVT.Focus();
                    return;
                }

            }
            if (txtTenVT.Text.Trim() == "")
            {
                MessageBox.Show("Tên vật tư không được thiếu!", "", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return;
            }
            if (txtDVT.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được thiếu!", "", MessageBoxButtons.OK);
                txtDVT.Focus();
                return;
            }
            if (txtSLT.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng tồn không được thiếu!", "", MessageBoxButtons.OK);
                txtSLT.Focus();
                return;
            }
            else
            {
                double n = double.Parse(txtSLT.Text.Trim());
                if(n<0)
                {
                    MessageBox.Show("Số lượng không hợp lệ", "Lỗi", MessageBoxButtons.OK);
                    txtSLT.Focus();
                    return;
                }
            }
            try
            {
                bdsVatTu.EndEdit();
                bdsVatTu.ResetCurrentItem();
                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Update(this.DS.Vattu);
                maVT = null;
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi vật tư: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled = btnRefresh.Enabled = vattuGridControl.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = groupBox1.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String mavt = ((DataRowView)bdsVatTu[bdsVatTu.Position])["MAVT"].ToString();
            if (bdsCTDDH.Count > 0) MessageBox.Show("Vật tư đã được đặt hàng, không thể xóa !", "Báo lỗi", MessageBoxButtons.OK);
            else
            {
                if(MessageBox.Show("Bạn có thật sự muốn xóa vật tư này", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bdsVatTu.RemoveCurrent();
                    try
                    {
                        this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.vattuTableAdapter.Update(this.DS.Vattu);
                    } catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa vật tư, bạn hãy xóa lại\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        this.vattuTableAdapter.Fill(this.DS.Vattu);
                        bdsVatTu.Position = bdsVatTu.Find("MAVT", mavt);
                        return;
                    }
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.vattuTableAdapter.Fill(this.DS.Vattu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload vật tư", "Lỗi", MessageBoxButtons.OK);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            groupBox1.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
            vattuGridControl.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVatTu.CancelEdit();
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnSua.Enabled = btnRefresh.Enabled = true;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.rptDanhSachVatTu rptDanhSachVatTu = new Report.rptDanhSachVatTu();
            rptDanhSachVatTu.lbHoTen.Text = Program.mHoTen;
            ReportPrintTool report = new ReportPrintTool(rptDanhSachVatTu);
            report.ShowPreviewDialog();
        }
    }
}
