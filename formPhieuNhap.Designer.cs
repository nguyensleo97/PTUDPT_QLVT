namespace QLVT
{
    partial class formPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAPNLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPhieuNhap));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDonGia_CTPN = new System.Windows.Forms.NumericUpDown();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.txtSoLuong_CTPN = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbThongTinVT = new System.Windows.Forms.Label();
            this.cbTenVatTuChuaNhap = new System.Windows.Forms.ComboBox();
            this.txtMaVT_CTPN = new System.Windows.Forms.TextBox();
            this.txtMaPN_CTPN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cTPNGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.standaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.standaloneBarDockControl3 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phieuNhapGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancel_PN = new System.Windows.Forms.Button();
            this.cbMaDDH = new System.Windows.Forms.ComboBox();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar8 = new DevExpress.XtraBars.Bar();
            this.btnThem_CTPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa_CTPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi_CTPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.phieuNhapTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.vattuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.cTPNTableAdapter = new QLVT.DSTableAdapters.CTPNTableAdapter();
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.DSTableAdapters.DatHangTableAdapter();
            this.bdsChiTietDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT.DSTableAdapters.CTDDHTableAdapter();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAPNLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia_CTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong_CTPN)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(32, 28);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(41, 13);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "MAPN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(33, 56);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(40, 13);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(10, 85);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(63, 13);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(32, 114);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(41, 13);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(24, 142);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(49, 13);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // mAPNLabel1
            // 
            mAPNLabel1.AutoSize = true;
            mAPNLabel1.Location = new System.Drawing.Point(38, 28);
            mAPNLabel1.Name = "mAPNLabel1";
            mAPNLabel1.Size = new System.Drawing.Size(41, 13);
            mAPNLabel1.TabIndex = 0;
            mAPNLabel1.Text = "MAPN:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(38, 56);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(16, 101);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(27, 130);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(52, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbChiNhanh);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 55);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chi nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(338, 18);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(200, 21);
            this.cmbChiNhanh.TabIndex = 2;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.04196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.95804F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 429);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtDonGia_CTPN);
            this.groupBox5.Controls.Add(this.txtSoLuong_CTPN);
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Controls.Add(this.btnOK);
            this.groupBox5.Controls.Add(this.lbThongTinVT);
            this.groupBox5.Controls.Add(this.cbTenVatTuChuaNhap);
            this.groupBox5.Controls.Add(dONGIALabel);
            this.groupBox5.Controls.Add(sOLUONGLabel);
            this.groupBox5.Controls.Add(mAVTLabel);
            this.groupBox5.Controls.Add(this.txtMaVT_CTPN);
            this.groupBox5.Controls.Add(mAPNLabel1);
            this.groupBox5.Controls.Add(this.txtMaPN_CTPN);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(403, 252);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(394, 174);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // txtDonGia_CTPN
            // 
            this.txtDonGia_CTPN.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTPN, "DONGIA", true));
            this.txtDonGia_CTPN.Location = new System.Drawing.Point(85, 125);
            this.txtDonGia_CTPN.Name = "txtDonGia_CTPN";
            this.txtDonGia_CTPN.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia_CTPN.TabIndex = 14;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsCTPN.DataSource = this.bdsPhieuNhap;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "PhieuNhap";
            this.bdsPhieuNhap.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSoLuong_CTPN
            // 
            this.txtSoLuong_CTPN.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTPN, "SOLUONG", true));
            this.txtSoLuong_CTPN.Location = new System.Drawing.Point(85, 99);
            this.txtSoLuong_CTPN.Name = "txtSoLuong_CTPN";
            this.txtSoLuong_CTPN.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong_CTPN.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(203, 142);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbThongTinVT
            // 
            this.lbThongTinVT.AutoSize = true;
            this.lbThongTinVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinVT.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbThongTinVT.Location = new System.Drawing.Point(82, 80);
            this.lbThongTinVT.Name = "lbThongTinVT";
            this.lbThongTinVT.Size = new System.Drawing.Size(13, 13);
            this.lbThongTinVT.TabIndex = 9;
            this.lbThongTinVT.Text = "  ";
            // 
            // cbTenVatTuChuaNhap
            // 
            this.cbTenVatTuChuaNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenVatTuChuaNhap.FormattingEnabled = true;
            this.cbTenVatTuChuaNhap.Location = new System.Drawing.Point(85, 56);
            this.cbTenVatTuChuaNhap.Name = "cbTenVatTuChuaNhap";
            this.cbTenVatTuChuaNhap.Size = new System.Drawing.Size(100, 21);
            this.cbTenVatTuChuaNhap.TabIndex = 8;
            this.cbTenVatTuChuaNhap.SelectedIndexChanged += new System.EventHandler(this.cbMaVTChuaNhap_SelectedIndexChanged);
            // 
            // txtMaVT_CTPN
            // 
            this.txtMaVT_CTPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "MAVT", true));
            this.txtMaVT_CTPN.Enabled = false;
            this.txtMaVT_CTPN.Location = new System.Drawing.Point(204, 57);
            this.txtMaVT_CTPN.Name = "txtMaVT_CTPN";
            this.txtMaVT_CTPN.Size = new System.Drawing.Size(100, 20);
            this.txtMaVT_CTPN.TabIndex = 3;
            // 
            // txtMaPN_CTPN
            // 
            this.txtMaPN_CTPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "MAPN", true));
            this.txtMaPN_CTPN.Enabled = false;
            this.txtMaPN_CTPN.Location = new System.Drawing.Point(85, 25);
            this.txtMaPN_CTPN.Name = "txtMaPN_CTPN";
            this.txtMaPN_CTPN.Size = new System.Drawing.Size(100, 20);
            this.txtMaPN_CTPN.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cTPNGridControl);
            this.groupBox2.Controls.Add(this.standaloneBarDockControl3);
            this.groupBox2.Controls.Add(this.standaloneBarDockControl2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(403, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // cTPNGridControl
            // 
            this.cTPNGridControl.DataSource = this.bdsCTPN;
            this.cTPNGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTPNGridControl.Location = new System.Drawing.Point(3, 40);
            this.cTPNGridControl.MainView = this.gridView2;
            this.cTPNGridControl.MenuManager = this.barManager1;
            this.cTPNGridControl.Name = "cTPNGridControl";
            this.cTPNGridControl.Size = new System.Drawing.Size(388, 200);
            this.cTPNGridControl.TabIndex = 4;
            this.cTPNGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.cTPNGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPN1
            // 
            this.colMAPN1.Caption = "Mã PN";
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.OptionsColumn.AllowEdit = false;
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "SOLUONG", "[0-9]{1,10}")});
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl2);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl3);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnRefresh1,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar5;
            this.barManager1.MaxItemId = 5;
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar5.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnRefresh1
            // 
            this.btnRefresh1.Caption = "Refresh";
            this.btnRefresh1.Id = 3;
            this.btnRefresh1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh1.ImageOptions.Image")));
            this.btnRefresh1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh1.ImageOptions.LargeImage")));
            this.btnRefresh1.Name = "btnRefresh1";
            this.btnRefresh1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh1_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xem Đơn ĐH";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(3, 16);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(388, 48);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 484);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 484);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 484);
            // 
            // standaloneBarDockControl2
            // 
            this.standaloneBarDockControl2.AutoSize = true;
            this.standaloneBarDockControl2.CausesValidation = false;
            this.standaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl2.Location = new System.Drawing.Point(3, 16);
            this.standaloneBarDockControl2.Manager = this.barManager1;
            this.standaloneBarDockControl2.Name = "standaloneBarDockControl2";
            this.standaloneBarDockControl2.Size = new System.Drawing.Size(388, 24);
            this.standaloneBarDockControl2.Text = "standaloneBarDockControl2";
            // 
            // standaloneBarDockControl3
            // 
            this.standaloneBarDockControl3.AutoSize = true;
            this.standaloneBarDockControl3.CausesValidation = false;
            this.standaloneBarDockControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl3.Location = new System.Drawing.Point(3, 40);
            this.standaloneBarDockControl3.Manager = this.barManager1;
            this.standaloneBarDockControl3.Name = "standaloneBarDockControl3";
            this.standaloneBarDockControl3.Size = new System.Drawing.Size(388, 0);
            this.standaloneBarDockControl3.Text = "standaloneBarDockControl3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phieuNhapGridControl);
            this.groupBox1.Controls.Add(this.standaloneBarDockControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập";
            // 
            // phieuNhapGridControl
            // 
            this.phieuNhapGridControl.DataSource = this.bdsPhieuNhap;
            this.phieuNhapGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phieuNhapGridControl.Location = new System.Drawing.Point(3, 64);
            this.phieuNhapGridControl.MainView = this.gridView1;
            this.phieuNhapGridControl.MenuManager = this.barManager1;
            this.phieuNhapGridControl.Name = "phieuNhapGridControl";
            this.phieuNhapGridControl.Size = new System.Drawing.Size(388, 176);
            this.phieuNhapGridControl.TabIndex = 1;
            this.phieuNhapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.phieuNhapGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "Mã PN";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.OptionsColumn.AllowEdit = false;
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã ĐĐH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.OptionsColumn.AllowEdit = false;
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel_PN);
            this.groupBox4.Controls.Add(this.cbMaDDH);
            this.groupBox4.Controls.Add(mAKHOLabel);
            this.groupBox4.Controls.Add(this.txtMaKho);
            this.groupBox4.Controls.Add(mANVLabel);
            this.groupBox4.Controls.Add(this.txtMaNV);
            this.groupBox4.Controls.Add(masoDDHLabel);
            this.groupBox4.Controls.Add(this.txtMaDDH);
            this.groupBox4.Controls.Add(nGAYLabel);
            this.groupBox4.Controls.Add(this.txtNgay);
            this.groupBox4.Controls.Add(mAPNLabel);
            this.groupBox4.Controls.Add(this.txtMaPN);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(3, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 174);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin phiếu nhập";
            // 
            // btnCancel_PN
            // 
            this.btnCancel_PN.Location = new System.Drawing.Point(291, 145);
            this.btnCancel_PN.Name = "btnCancel_PN";
            this.btnCancel_PN.Size = new System.Drawing.Size(75, 23);
            this.btnCancel_PN.TabIndex = 13;
            this.btnCancel_PN.Text = "Cancel";
            this.btnCancel_PN.UseVisualStyleBackColor = true;
            this.btnCancel_PN.Click += new System.EventHandler(this.btnCancel_PN_Click);
            // 
            // cbMaDDH
            // 
            this.cbMaDDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaDDH.FormattingEnabled = true;
            this.cbMaDDH.Location = new System.Drawing.Point(80, 82);
            this.cbMaDDH.Name = "cbMaDDH";
            this.cbMaDDH.Size = new System.Drawing.Size(99, 21);
            this.cbMaDDH.TabIndex = 10;
            this.cbMaDDH.SelectedIndexChanged += new System.EventHandler(this.cbMaDDH_SelectedIndexChanged);
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MAKHO", true));
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Location = new System.Drawing.Point(79, 139);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(100, 20);
            this.txtMaKho.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(79, 111);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MasoDDH", true));
            this.txtMaDDH.Enabled = false;
            this.txtMaDDH.Location = new System.Drawing.Point(195, 82);
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(100, 20);
            this.txtMaDDH.TabIndex = 5;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsPhieuNhap, "NGAY", true));
            this.txtNgay.Location = new System.Drawing.Point(79, 52);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(200, 20);
            this.txtNgay.TabIndex = 3;
            // 
            // txtMaPN
            // 
            this.txtMaPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MAPN", true));
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Location = new System.Drawing.Point(79, 25);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(100, 20);
            this.txtMaPN.TabIndex = 1;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh1)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar4.Text = "Main menu";
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar8});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem_CTPN,
            this.btnGhi_CTPN,
            this.btnHuy,
            this.btnXoa_CTPN});
            this.barManager2.MainMenu = this.bar8;
            this.barManager2.MaxItemId = 4;
            // 
            // bar8
            // 
            this.bar8.BarName = "Main menu";
            this.bar8.DockCol = 0;
            this.bar8.DockRow = 0;
            this.bar8.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem_CTPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa_CTPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi_CTPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar8.OptionsBar.MultiLine = true;
            this.bar8.OptionsBar.UseWholeRow = true;
            this.bar8.StandaloneBarDockControl = this.standaloneBarDockControl2;
            this.bar8.Text = "Main menu";
            // 
            // btnThem_CTPN
            // 
            this.btnThem_CTPN.Caption = "Thêm";
            this.btnThem_CTPN.Enabled = false;
            this.btnThem_CTPN.Id = 0;
            this.btnThem_CTPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_CTPN.ImageOptions.Image")));
            this.btnThem_CTPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem_CTPN.ImageOptions.LargeImage")));
            this.btnThem_CTPN.Name = "btnThem_CTPN";
            this.btnThem_CTPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_CTPN_ItemClick);
            // 
            // btnXoa_CTPN
            // 
            this.btnXoa_CTPN.Caption = "Xóa";
            this.btnXoa_CTPN.Enabled = false;
            this.btnXoa_CTPN.Id = 3;
            this.btnXoa_CTPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_CTPN.ImageOptions.Image")));
            this.btnXoa_CTPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa_CTPN.ImageOptions.LargeImage")));
            this.btnXoa_CTPN.Name = "btnXoa_CTPN";
            this.btnXoa_CTPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_CTPN_ItemClick);
            // 
            // btnGhi_CTPN
            // 
            this.btnGhi_CTPN.Caption = "Ghi";
            this.btnGhi_CTPN.Enabled = false;
            this.btnGhi_CTPN.Id = 1;
            this.btnGhi_CTPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi_CTPN.ImageOptions.Image")));
            this.btnGhi_CTPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi_CTPN.ImageOptions.LargeImage")));
            this.btnGhi_CTPN.Name = "btnGhi_CTPN";
            this.btnGhi_CTPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_CTPN_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Enabled = false;
            this.btnHuy.Id = 2;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 484);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 484);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(800, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 484);
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDatHang
            // 
            this.bdsDatHang.DataMember = "DatHang";
            this.bdsDatHang.DataSource = this.DS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // bdsChiTietDatHang
            // 
            this.bdsChiTietDatHang.DataMember = "CTDDH";
            this.bdsChiTietDatHang.DataSource = this.DS;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // formPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "formPhieuNhap";
            this.Text = "Phiếu nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formPhieuNhap_FormClosed);
            this.Load += new System.EventHandler(this.formPhieuNhap_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia_CTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong_CTPN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarButtonItem btnRefresh1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl2;
        private DS DS;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar8;
        private DevExpress.XtraBars.BarButtonItem btnThem_CTPN;
        private DevExpress.XtraBars.BarButtonItem btnGhi_CTPN;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar4;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl phieuNhapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaDDH;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.TextBox txtMaPN;
        public System.Windows.Forms.GroupBox groupBox2;
        public DevExpress.XtraBars.BarButtonItem btnThem;
        public DevExpress.XtraBars.BarButtonItem btnXoa;
        public DevExpress.XtraBars.BarButtonItem btnGhi;
        public System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.BindingSource bdsPhieuNhap;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private DevExpress.XtraGrid.GridControl cTPNGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.TextBox txtMaVT_CTPN;
        private System.Windows.Forms.TextBox txtMaPN_CTPN;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.ComboBox cbTenVatTuChuaNhap;
        private System.Windows.Forms.BindingSource bdsChiTietDatHang;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.Label lbThongTinVT;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraBars.BarButtonItem btnXoa_CTPN;
        public System.Windows.Forms.ComboBox cbMaDDH;
        private System.Windows.Forms.Button btnCancel_PN;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.NumericUpDown txtDonGia_CTPN;
        private System.Windows.Forms.NumericUpDown txtSoLuong_CTPN;
    }
}