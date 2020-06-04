namespace QLVT
{
    partial class formPhieuNhap1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbMaVTCN = new System.Windows.Forms.ComboBox();
            this.cbVT = new System.Windows.Forms.ComboBox();
            this.bntHuy_1 = new System.Windows.Forms.Button();
            this.btnOK_1 = new System.Windows.Forms.Button();
            this.txtDonGia_CTPN = new System.Windows.Forms.TextBox();
            this.bdsChiTietPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.fKCTPNPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.txtSoLuong_CTPN = new System.Windows.Forms.TextBox();
            this.txtMaVT_CTPN = new System.Windows.Forms.TextBox();
            this.mAPNTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.khoComboBox = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAKHOTextBox = new System.Windows.Forms.TextBox();
            this.mANVTextBox = new System.Windows.Forms.TextBox();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.nGAYDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mAPNTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cTPNGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.standaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.phieuNhapGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cTDDHGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsChiTietDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.fKCTDDHDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.qLVTDataSet = new QLVT.QLVTDataSet();
            this.datHangTableAdapter = new QLVT.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVT.DSTableAdapters.CTDDHTableAdapter();
            this.cTPNTableAdapter = new QLVT.DSTableAdapters.CTPNTableAdapter();
            this.phieuNhapTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barManager3 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.khoTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            this.tableAdapterManager1 = new QLVT.QLVTDataSetTableAdapters.TableAdapterManager();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAPNLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTDDHDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(24, 16);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(41, 13);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "MAPN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(24, 42);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(40, 13);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(24, 67);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(63, 13);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(24, 96);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(41, 13);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(16, 122);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(49, 13);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // mAPNLabel1
            // 
            mAPNLabel1.AutoSize = true;
            mAPNLabel1.Location = new System.Drawing.Point(6, 20);
            mAPNLabel1.Name = "mAPNLabel1";
            mAPNLabel1.Size = new System.Drawing.Size(41, 13);
            mAPNLabel1.TabIndex = 0;
            mAPNLabel1.Text = "MAPN:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(6, 45);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(6, 74);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(6, 100);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(52, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.80161F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.19839F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 510);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbMaVTCN);
            this.groupBox6.Controls.Add(this.cbVT);
            this.groupBox6.Controls.Add(this.bntHuy_1);
            this.groupBox6.Controls.Add(this.btnOK_1);
            this.groupBox6.Controls.Add(dONGIALabel);
            this.groupBox6.Controls.Add(this.txtDonGia_CTPN);
            this.groupBox6.Controls.Add(sOLUONGLabel);
            this.groupBox6.Controls.Add(this.txtSoLuong_CTPN);
            this.groupBox6.Controls.Add(mAVTLabel);
            this.groupBox6.Controls.Add(this.txtMaVT_CTPN);
            this.groupBox6.Controls.Add(mAPNLabel1);
            this.groupBox6.Controls.Add(this.mAPNTextBox1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(403, 329);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(394, 178);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // cbMaVTCN
            // 
            this.cbMaVTCN.FormattingEnabled = true;
            this.cbMaVTCN.Location = new System.Drawing.Point(54, 42);
            this.cbMaVTCN.Name = "cbMaVTCN";
            this.cbMaVTCN.Size = new System.Drawing.Size(99, 21);
            this.cbMaVTCN.TabIndex = 16;
            this.cbMaVTCN.SelectedIndexChanged += new System.EventHandler(this.cbMaVTCN_SelectedIndexChanged);
            // 
            // cbVT
            // 
            this.cbVT.FormattingEnabled = true;
            this.cbVT.Location = new System.Drawing.Point(159, 41);
            this.cbVT.Name = "cbVT";
            this.cbVT.Size = new System.Drawing.Size(74, 21);
            this.cbVT.TabIndex = 15;
            // 
            // bntHuy_1
            // 
            this.bntHuy_1.Location = new System.Drawing.Point(203, 146);
            this.bntHuy_1.Name = "bntHuy_1";
            this.bntHuy_1.Size = new System.Drawing.Size(75, 23);
            this.bntHuy_1.TabIndex = 14;
            this.bntHuy_1.Text = "Hủy";
            this.bntHuy_1.UseVisualStyleBackColor = true;
            this.bntHuy_1.Click += new System.EventHandler(this.bntHuy_1_Click);
            // 
            // btnOK_1
            // 
            this.btnOK_1.Location = new System.Drawing.Point(122, 146);
            this.btnOK_1.Name = "btnOK_1";
            this.btnOK_1.Size = new System.Drawing.Size(75, 23);
            this.btnOK_1.TabIndex = 13;
            this.btnOK_1.Text = "OK";
            this.btnOK_1.UseVisualStyleBackColor = true;
            this.btnOK_1.Click += new System.EventHandler(this.btnOK_1_Click);
            // 
            // txtDonGia_CTPN
            // 
            this.txtDonGia_CTPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsChiTietPhieuNhap, "DONGIA", true));
            this.txtDonGia_CTPN.Location = new System.Drawing.Point(64, 97);
            this.txtDonGia_CTPN.Name = "txtDonGia_CTPN";
            this.txtDonGia_CTPN.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia_CTPN.TabIndex = 7;
            // 
            // bdsChiTietPhieuNhap
            // 
            this.bdsChiTietPhieuNhap.DataSource = this.fKCTPNPhieuNhapBindingSource;
            // 
            // fKCTPNPhieuNhapBindingSource
            // 
            this.fKCTPNPhieuNhapBindingSource.DataMember = "FK_CTPN_PhieuNhap";
            this.fKCTPNPhieuNhapBindingSource.DataSource = this.bdsPhieuNhap;
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
            this.txtSoLuong_CTPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsChiTietPhieuNhap, "SOLUONG", true));
            this.txtSoLuong_CTPN.Location = new System.Drawing.Point(75, 68);
            this.txtSoLuong_CTPN.Name = "txtSoLuong_CTPN";
            this.txtSoLuong_CTPN.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong_CTPN.TabIndex = 5;
            // 
            // txtMaVT_CTPN
            // 
            this.txtMaVT_CTPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsChiTietPhieuNhap, "MAVT", true));
            this.txtMaVT_CTPN.Location = new System.Drawing.Point(254, 41);
            this.txtMaVT_CTPN.Name = "txtMaVT_CTPN";
            this.txtMaVT_CTPN.Size = new System.Drawing.Size(100, 20);
            this.txtMaVT_CTPN.TabIndex = 3;
            // 
            // mAPNTextBox1
            // 
            this.mAPNTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsChiTietPhieuNhap, "MAPN", true));
            this.mAPNTextBox1.Location = new System.Drawing.Point(53, 17);
            this.mAPNTextBox1.Name = "mAPNTextBox1";
            this.mAPNTextBox1.Size = new System.Drawing.Size(100, 20);
            this.mAPNTextBox1.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnHuy);
            this.groupBox5.Controls.Add(this.btnOK);
            this.groupBox5.Controls.Add(this.khoComboBox);
            this.groupBox5.Controls.Add(mAKHOLabel);
            this.groupBox5.Controls.Add(this.mAKHOTextBox);
            this.groupBox5.Controls.Add(mANVLabel);
            this.groupBox5.Controls.Add(this.mANVTextBox);
            this.groupBox5.Controls.Add(masoDDHLabel);
            this.groupBox5.Controls.Add(this.txtMaDDH);
            this.groupBox5.Controls.Add(nGAYLabel);
            this.groupBox5.Controls.Add(this.nGAYDateTimePicker);
            this.groupBox5.Controls.Add(mAPNLabel);
            this.groupBox5.Controls.Add(this.mAPNTextBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 329);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(394, 178);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(176, 146);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(95, 146);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // khoComboBox
            // 
            this.khoComboBox.DataSource = this.khoBindingSource;
            this.khoComboBox.DisplayMember = "TENKHO";
            this.khoComboBox.FormattingEnabled = true;
            this.khoComboBox.Location = new System.Drawing.Point(70, 118);
            this.khoComboBox.Name = "khoComboBox";
            this.khoComboBox.Size = new System.Drawing.Size(121, 21);
            this.khoComboBox.TabIndex = 10;
            this.khoComboBox.ValueMember = "MAKHO";
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.DS;
            // 
            // mAKHOTextBox
            // 
            this.mAKHOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MAKHO", true));
            this.mAKHOTextBox.Location = new System.Drawing.Point(197, 119);
            this.mAKHOTextBox.Name = "mAKHOTextBox";
            this.mAKHOTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAKHOTextBox.TabIndex = 9;
            // 
            // mANVTextBox
            // 
            this.mANVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MANV", true));
            this.mANVTextBox.Location = new System.Drawing.Point(71, 93);
            this.mANVTextBox.Name = "mANVTextBox";
            this.mANVTextBox.Size = new System.Drawing.Size(100, 20);
            this.mANVTextBox.TabIndex = 7;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MasoDDH", true));
            this.txtMaDDH.Location = new System.Drawing.Point(93, 64);
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(100, 20);
            this.txtMaDDH.TabIndex = 5;
            // 
            // nGAYDateTimePicker
            // 
            this.nGAYDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsPhieuNhap, "NGAY", true));
            this.nGAYDateTimePicker.Location = new System.Drawing.Point(70, 38);
            this.nGAYDateTimePicker.Name = "nGAYDateTimePicker";
            this.nGAYDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.nGAYDateTimePicker.TabIndex = 3;
            // 
            // mAPNTextBox
            // 
            this.mAPNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MAPN", true));
            this.mAPNTextBox.Location = new System.Drawing.Point(71, 13);
            this.mAPNTextBox.Name = "mAPNTextBox";
            this.mAPNTextBox.Size = new System.Drawing.Size(100, 20);
            this.mAPNTextBox.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cTPNGridControl);
            this.groupBox4.Controls.Add(this.standaloneBarDockControl2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(403, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 197);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // cTPNGridControl
            // 
            this.cTPNGridControl.DataSource = this.bdsChiTietPhieuNhap;
            this.cTPNGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTPNGridControl.Location = new System.Drawing.Point(3, 38);
            this.cTPNGridControl.MainView = this.gridView4;
            this.cTPNGridControl.MenuManager = this.barManager1;
            this.cTPNGridControl.Name = "cTPNGridControl";
            this.cTPNGridControl.Size = new System.Drawing.Size(388, 156);
            this.cTPNGridControl.TabIndex = 1;
            this.cTPNGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colMAVT1,
            this.colSOLUONG1,
            this.colDONGIA1});
            this.gridView4.GridControl = this.cTPNGridControl;
            this.gridView4.Name = "gridView4";
            // 
            // colMAPN
            // 
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            // 
            // colMAVT1
            // 
            this.colMAVT1.FieldName = "MAVT";
            this.colMAVT1.Name = "colMAVT1";
            this.colMAVT1.Visible = true;
            this.colMAVT1.VisibleIndex = 1;
            // 
            // colSOLUONG1
            // 
            this.colSOLUONG1.FieldName = "SOLUONG";
            this.colSOLUONG1.Name = "colSOLUONG1";
            this.colSOLUONG1.Visible = true;
            this.colSOLUONG1.VisibleIndex = 2;
            // 
            // colDONGIA1
            // 
            this.colDONGIA1.FieldName = "DONGIA";
            this.colDONGIA1.Name = "colDONGIA1";
            this.colDONGIA1.Visible = true;
            this.colDONGIA1.VisibleIndex = 3;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl2);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Ghi";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "ReLoad";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thoat";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 532);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 510);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 22);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 510);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(3, 16);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(388, 22);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // standaloneBarDockControl2
            // 
            this.standaloneBarDockControl2.AutoSize = true;
            this.standaloneBarDockControl2.CausesValidation = false;
            this.standaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl2.Location = new System.Drawing.Point(3, 16);
            this.standaloneBarDockControl2.Manager = this.barManager1;
            this.standaloneBarDockControl2.Name = "standaloneBarDockControl2";
            this.standaloneBarDockControl2.Size = new System.Drawing.Size(388, 22);
            this.standaloneBarDockControl2.Text = "standaloneBarDockControl2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.phieuNhapGridControl);
            this.groupBox3.Controls.Add(this.standaloneBarDockControl1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 197);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // phieuNhapGridControl
            // 
            this.phieuNhapGridControl.DataSource = this.bdsPhieuNhap;
            this.phieuNhapGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phieuNhapGridControl.Location = new System.Drawing.Point(3, 38);
            this.phieuNhapGridControl.MainView = this.gridView3;
            this.phieuNhapGridControl.MenuManager = this.barManager1;
            this.phieuNhapGridControl.Name = "phieuNhapGridControl";
            this.phieuNhapGridControl.Size = new System.Drawing.Size(388, 156);
            this.phieuNhapGridControl.TabIndex = 1;
            this.phieuNhapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.phieuNhapGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cTDDHGridControl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(403, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cTDDHGridControl
            // 
            this.cTDDHGridControl.DataSource = this.bdsChiTietDatHang;
            this.cTDDHGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTDDHGridControl.Location = new System.Drawing.Point(3, 16);
            this.cTDDHGridControl.MainView = this.gridView2;
            this.cTDDHGridControl.MenuManager = this.barManager1;
            this.cTDDHGridControl.Name = "cTDDHGridControl";
            this.cTDDHGridControl.Size = new System.Drawing.Size(388, 98);
            this.cTDDHGridControl.TabIndex = 0;
            this.cTDDHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsChiTietDatHang
            // 
            this.bdsChiTietDatHang.DataSource = this.fKCTDDHDatHangBindingSource;
            // 
            // fKCTDDHDatHangBindingSource
            // 
            this.fKCTDDHDatHangBindingSource.DataMember = "FK_CTDDH_DatHang";
            this.fKCTDDHDatHangBindingSource.DataSource = this.bdsDatHang;
            // 
            // bdsDatHang
            // 
            this.bdsDatHang.DataMember = "DatHang";
            this.bdsDatHang.DataSource = this.DS;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.cTDDHGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datHangGridControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // datHangGridControl
            // 
            this.datHangGridControl.DataSource = this.bdsDatHang;
            this.datHangGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datHangGridControl.Location = new System.Drawing.Point(3, 16);
            this.datHangGridControl.MainView = this.gridView1;
            this.datHangGridControl.MenuManager = this.barManager1;
            this.datHangGridControl.Name = "datHangGridControl";
            this.datHangGridControl.Size = new System.Drawing.Size(388, 98);
            this.datHangGridControl.TabIndex = 0;
            this.datHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView5});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.datHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colNhaCC
            // 
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.datHangGridControl;
            this.gridView5.Name = "gridView5";
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager2.MainMenu = this.bar3;
            this.barManager2.MaxItemId = 2;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar3.Text = "Main menu";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thêm";
            this.barButtonItem4.Id = 0;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Phục hồi";
            this.barButtonItem5.Id = 1;
            this.barButtonItem5.Name = "barButtonItem5";
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
            this.barDockControl2.Location = new System.Drawing.Point(0, 532);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 532);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(800, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 532);
            // 
            // barManager3
            // 
            this.barManager3.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar5});
            this.barManager3.DockControls.Add(this.barDockControl5);
            this.barManager3.DockControls.Add(this.barDockControl6);
            this.barManager3.DockControls.Add(this.barDockControl7);
            this.barManager3.DockControls.Add(this.barDockControl8);
            this.barManager3.Form = this;
            this.barManager3.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem6,
            this.barButtonItem7});
            this.barManager3.MainMenu = this.bar5;
            this.barManager3.MaxItemId = 2;
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7)});
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.StandaloneBarDockControl = this.standaloneBarDockControl2;
            this.bar5.Text = "Main menu";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Thêm";
            this.barButtonItem6.Id = 0;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Phục hồi";
            this.barButtonItem7.Id = 1;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barManager3;
            this.barDockControl5.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 532);
            this.barDockControl6.Manager = this.barManager3;
            this.barDockControl6.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 0);
            this.barDockControl7.Manager = this.barManager3;
            this.barDockControl7.Size = new System.Drawing.Size(0, 532);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(800, 0);
            this.barDockControl8.Manager = this.barManager3;
            this.barDockControl8.Size = new System.Drawing.Size(0, 532);
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QLVT.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.DS;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // formPhieuNhap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Name = "formPhieuNhap1";
            this.Text = "formDonDatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formDonDatHang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTDDHDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private DS DS;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsChiTietDatHang;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl2;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DevExpress.XtraGrid.GridControl phieuNhapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsChiTietPhieuNhap;
        private DevExpress.XtraGrid.GridControl cTPNGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.TextBox txtDonGia_CTPN;
        private System.Windows.Forms.TextBox txtSoLuong_CTPN;
        private System.Windows.Forms.TextBox txtMaVT_CTPN;
        private System.Windows.Forms.TextBox mAPNTextBox1;
        private System.Windows.Forms.TextBox mAKHOTextBox;
        private System.Windows.Forms.TextBox mANVTextBox;
        private System.Windows.Forms.TextBox txtMaDDH;
        private System.Windows.Forms.DateTimePicker nGAYDateTimePicker;
        private System.Windows.Forms.TextBox mAPNTextBox;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.Button bntHuy_1;
        private System.Windows.Forms.Button btnOK_1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox khoComboBox;
        private System.Windows.Forms.BindingSource fKCTDDHDatHangBindingSource;
        private QLVTDataSet qLVTDataSet;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource fKCTPNPhieuNhapBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG1;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA1;
        private System.Windows.Forms.ComboBox cbVT;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.ComboBox cbMaVTCN;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl cTDDHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl datHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
    }
}