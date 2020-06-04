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
    public partial class formPhieuNhap1 : Form
    {
        Dictionary<string, int> vatTuDaNhap = null;
        public formPhieuNhap1()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formDonDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            // TODO: This line of code loads data into the 'DS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.DS.CTPN);

            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPhieuNhap.AddNew();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbMaVTCN.Items.Clear();
            cbVT.Items.Clear();
            vatTuDaNhap = new Dictionary<string, int>();

            String maDHDuocChon = ((DataRowView)bdsPhieuNhap.Current)["MasoDDH"].ToString();
            int viTriCanChon = bdsDatHang.Find("MasoDDH", maDHDuocChon);
            gridView1.FocusedRowHandle = viTriCanChon;

            int demVatTuChuaNhap = bdsChiTietDatHang.Count;
            for (int i = 0; i < bdsChiTietDatHang.Count; i++)
            {
                vatTuDaNhap.Add(((DataRowView)bdsChiTietDatHang[i])["MAVT"].ToString().Trim(), (int)((DataRowView)bdsChiTietDatHang[i])["SOLUONG"]);
            }
            for(int i=0; i< bdsChiTietPhieuNhap.Count; i++)
            {
                vatTuDaNhap[((DataRowView)bdsChiTietPhieuNhap[i])["MAVT"].ToString().Trim()] -= (int)((DataRowView)bdsChiTietPhieuNhap[i])["SOLUONG"];
            }
            for(int i=0; i<vatTuDaNhap.Count; i++)
            {
                //vatTuDaNhap.ElementAt(i).Value;
                KeyValuePair<String, int> keyValuePair = vatTuDaNhap.ElementAt(i);
                if (keyValuePair.Value != 0)
                {
                    int vt = vattuBindingSource.Find("MAVT", keyValuePair.Key);
                    cbMaVTCN.Items.Add(((DataRowView)vattuBindingSource[vt])["TENVT"].ToString());
                    cbVT.Items.Add(keyValuePair.Key);
                }
                else
                {
                    demVatTuChuaNhap--;
                    vatTuDaNhap.Remove(keyValuePair.Key);
                }
            }

            if (demVatTuChuaNhap == 0)
            {
                MessageBox.Show("Đơn hàng đã hoàn tất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            bdsChiTietPhieuNhap.AddNew();
     
            mAPNTextBox1.Text = mAPNTextBox.Text;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bdsPhieuNhap.EndEdit();
        }

        private void btnOK_1_Click(object sender, EventArgs e)
        {
            int soLuong = int.Parse(txtSoLuong_CTPN.Text);
            String maVT = txtMaVT_CTPN.Text;
            if (soLuong > vatTuDaNhap[maVT]) MessageBox.Show(soLuong + " > " + vatTuDaNhap[maVT]);
            bdsChiTietPhieuNhap.EndEdit();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bdsPhieuNhap.CancelEdit();
        }

        private void bntHuy_1_Click(object sender, EventArgs e)
        {
            bdsChiTietPhieuNhap.CancelEdit();
        }

        private void cbMaVTCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vt = cbMaVTCN.SelectedIndex;
            MessageBox.Show(vatTuDaNhap.ElementAt(vt).Key);
        }
    }
}
