namespace QLVT
{
    partial class formPhieuXuat
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAPXLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPhieuXuat));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDonGia_CTPX = new System.Windows.Forms.NumericUpDown();
            this.bdsChiTietPhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.txtSoLuong_CTPX = new System.Windows.Forms.NumericUpDown();
            this.lbThongTinVT = new System.Windows.Forms.Label();
            this.cbMaVT_CTPX = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMaVT_CTPX = new System.Windows.Forms.TextBox();
            this.txtMaPX_CTPX = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbMaKho = new System.Windows.Forms.ComboBox();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel_PN = new System.Windows.Forms.Button();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.txtMaPX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cTPXGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.standaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phieuXuatGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phieuXuatTableAdapter = new QLVT.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.cTPXTableAdapter = new QLVT.DSTableAdapters.CTPXTableAdapter();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnThem_CTPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa_CTPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi_CTPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy_CTPN = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.khoTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAPXLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia_CTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong_CTPX)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(32, 32);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(40, 13);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "MAPX:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(32, 59);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(40, 13);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(9, 88);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(63, 13);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "HOTENKH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(31, 114);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(41, 13);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(23, 140);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(49, 13);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // mAPXLabel1
            // 
            mAPXLabel1.AutoSize = true;
            mAPXLabel1.Location = new System.Drawing.Point(29, 29);
            mAPXLabel1.Name = "mAPXLabel1";
            mAPXLabel1.Size = new System.Drawing.Size(40, 13);
            mAPXLabel1.TabIndex = 0;
            mAPXLabel1.Text = "MAPX:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(29, 55);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(6, 85);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(17, 114);
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
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.68354F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.31646F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 395);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtDonGia_CTPX);
            this.groupBox5.Controls.Add(this.txtSoLuong_CTPX);
            this.groupBox5.Controls.Add(this.lbThongTinVT);
            this.groupBox5.Controls.Add(this.cbMaVT_CTPX);
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Controls.Add(this.btnOK);
            this.groupBox5.Controls.Add(dONGIALabel);
            this.groupBox5.Controls.Add(sOLUONGLabel);
            this.groupBox5.Controls.Add(mAVTLabel);
            this.groupBox5.Controls.Add(this.txtMaVT_CTPX);
            this.groupBox5.Controls.Add(mAPXLabel1);
            this.groupBox5.Controls.Add(this.txtMaPX_CTPX);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(403, 218);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(394, 174);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin chi tiết phiếu xuất";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // txtDonGia_CTPX
            // 
            this.txtDonGia_CTPX.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsChiTietPhieuXuat, "DONGIA", true));
            this.txtDonGia_CTPX.Location = new System.Drawing.Point(76, 111);
            this.txtDonGia_CTPX.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtDonGia_CTPX.Name = "txtDonGia_CTPX";
            this.txtDonGia_CTPX.Size = new System.Drawing.Size(99, 20);
            this.txtDonGia_CTPX.TabIndex = 18;
            // 
            // bdsChiTietPhieuXuat
            // 
            this.bdsChiTietPhieuXuat.DataMember = "FK_CTPX_PX";
            this.bdsChiTietPhieuXuat.DataSource = this.bdsPhieuXuat;
            // 
            // bdsPhieuXuat
            // 
            this.bdsPhieuXuat.DataMember = "PhieuXuat";
            this.bdsPhieuXuat.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSoLuong_CTPX
            // 
            this.txtSoLuong_CTPX.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsChiTietPhieuXuat, "SOLUONG", true));
            this.txtSoLuong_CTPX.Location = new System.Drawing.Point(76, 85);
            this.txtSoLuong_CTPX.Name = "txtSoLuong_CTPX";
            this.txtSoLuong_CTPX.Size = new System.Drawing.Size(99, 20);
            this.txtSoLuong_CTPX.TabIndex = 17;
            this.txtSoLuong_CTPX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSoLuong_CTPX_KeyUp);
            this.txtSoLuong_CTPX.Move += new System.EventHandler(this.txtSoLuong_CTPX_Move);
            // 
            // lbThongTinVT
            // 
            this.lbThongTinVT.AutoSize = true;
            this.lbThongTinVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinVT.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbThongTinVT.Location = new System.Drawing.Point(291, 59);
            this.lbThongTinVT.Name = "lbThongTinVT";
            this.lbThongTinVT.Size = new System.Drawing.Size(13, 13);
            this.lbThongTinVT.TabIndex = 16;
            this.lbThongTinVT.Text = "  ";
            // 
            // cbMaVT_CTPX
            // 
            this.cbMaVT_CTPX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaVT_CTPX.FormattingEnabled = true;
            this.cbMaVT_CTPX.Location = new System.Drawing.Point(76, 54);
            this.cbMaVT_CTPX.Name = "cbMaVT_CTPX";
            this.cbMaVT_CTPX.Size = new System.Drawing.Size(99, 21);
            this.cbMaVT_CTPX.TabIndex = 15;
            this.cbMaVT_CTPX.SelectedIndexChanged += new System.EventHandler(this.cbMaVT_CTPX_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(214, 140);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMaVT_CTPX
            // 
            this.txtMaVT_CTPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsChiTietPhieuXuat, "MAVT", true));
            this.txtMaVT_CTPX.Enabled = false;
            this.txtMaVT_CTPX.Location = new System.Drawing.Point(178, 54);
            this.txtMaVT_CTPX.Name = "txtMaVT_CTPX";
            this.txtMaVT_CTPX.Size = new System.Drawing.Size(100, 20);
            this.txtMaVT_CTPX.TabIndex = 3;
            // 
            // txtMaPX_CTPX
            // 
            this.txtMaPX_CTPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsChiTietPhieuXuat, "MAPX", true));
            this.txtMaPX_CTPX.Enabled = false;
            this.txtMaPX_CTPX.Location = new System.Drawing.Point(75, 26);
            this.txtMaPX_CTPX.Name = "txtMaPX_CTPX";
            this.txtMaPX_CTPX.Size = new System.Drawing.Size(100, 20);
            this.txtMaPX_CTPX.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbMaKho);
            this.groupBox4.Controls.Add(this.btnCancel_PN);
            this.groupBox4.Controls.Add(mAKHOLabel);
            this.groupBox4.Controls.Add(this.txtMaKho);
            this.groupBox4.Controls.Add(mANVLabel);
            this.groupBox4.Controls.Add(this.txtMaNV);
            this.groupBox4.Controls.Add(hOTENKHLabel);
            this.groupBox4.Controls.Add(this.txtHoTenKH);
            this.groupBox4.Controls.Add(nGAYLabel);
            this.groupBox4.Controls.Add(this.txtNgay);
            this.groupBox4.Controls.Add(mAPXLabel);
            this.groupBox4.Controls.Add(this.txtMaPX);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(3, 218);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 174);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin phiếu xuất";
            // 
            // cbMaKho
            // 
            this.cbMaKho.DataSource = this.bdsKho;
            this.cbMaKho.DisplayMember = "TENKHO";
            this.cbMaKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKho.FormattingEnabled = true;
            this.cbMaKho.Location = new System.Drawing.Point(78, 137);
            this.cbMaKho.Name = "cbMaKho";
            this.cbMaKho.Size = new System.Drawing.Size(100, 21);
            this.cbMaKho.TabIndex = 14;
            this.cbMaKho.ValueMember = "MAKHO";
            this.cbMaKho.SelectedIndexChanged += new System.EventHandler(this.cbMaKho_SelectedIndexChanged);
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.DS;
            // 
            // btnCancel_PN
            // 
            this.btnCancel_PN.Location = new System.Drawing.Point(297, 140);
            this.btnCancel_PN.Name = "btnCancel_PN";
            this.btnCancel_PN.Size = new System.Drawing.Size(75, 23);
            this.btnCancel_PN.TabIndex = 14;
            this.btnCancel_PN.Text = "Cancel";
            this.btnCancel_PN.UseVisualStyleBackColor = true;
            this.btnCancel_PN.Click += new System.EventHandler(this.btnCancel_PN_Click);
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuXuat, "MAKHO", true));
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Location = new System.Drawing.Point(185, 137);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(93, 20);
            this.txtMaKho.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuXuat, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(78, 111);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuXuat, "HOTENKH", true));
            this.txtHoTenKH.Location = new System.Drawing.Point(78, 85);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(200, 20);
            this.txtHoTenKH.TabIndex = 5;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsPhieuXuat, "NGAY", true));
            this.txtNgay.Location = new System.Drawing.Point(78, 55);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(200, 20);
            this.txtNgay.TabIndex = 3;
            // 
            // txtMaPX
            // 
            this.txtMaPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuXuat, "MAPX", true));
            this.txtMaPX.Location = new System.Drawing.Point(78, 29);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(100, 20);
            this.txtMaPX.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cTPXGridControl);
            this.groupBox2.Controls.Add(this.standaloneBarDockControl2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(403, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu xuất";
            // 
            // cTPXGridControl
            // 
            this.cTPXGridControl.DataSource = this.bdsChiTietPhieuXuat;
            this.cTPXGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTPXGridControl.Location = new System.Drawing.Point(3, 40);
            this.cTPXGridControl.MainView = this.gridView2;
            this.cTPXGridControl.MenuManager = this.barManager1;
            this.cTPXGridControl.Name = "cTPXGridControl";
            this.cTPXGridControl.Size = new System.Drawing.Size(388, 166);
            this.cTPXGridControl.TabIndex = 1;
            this.cTPXGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.cTPXGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // colMAPX1
            // 
            this.colMAPX1.Caption = "Mã PX";
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.OptionsColumn.AllowEdit = false;
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
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
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
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
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl2);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.barButtonItem2,
            this.btnGhi,
            this.btnXoa,
            this.btnRefresh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
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
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(3, 16);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(388, 24);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 450);
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
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xóa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phieuXuatGridControl);
            this.groupBox1.Controls.Add(this.standaloneBarDockControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu xuất";
            // 
            // phieuXuatGridControl
            // 
            this.phieuXuatGridControl.DataSource = this.bdsPhieuXuat;
            this.phieuXuatGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phieuXuatGridControl.Location = new System.Drawing.Point(3, 40);
            this.phieuXuatGridControl.MainView = this.gridView1;
            this.phieuXuatGridControl.MenuManager = this.barManager1;
            this.phieuXuatGridControl.Name = "phieuXuatGridControl";
            this.phieuXuatGridControl.Size = new System.Drawing.Size(388, 166);
            this.phieuXuatGridControl.TabIndex = 1;
            this.phieuXuatGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.phieuXuatGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã PX";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.OptionsColumn.AllowEdit = false;
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
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
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Họ tên KH";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.OptionsColumn.AllowEdit = false;
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
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
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem_CTPN,
            this.btnXoa_CTPN,
            this.btnGhi_CTPN,
            this.btnHuy_CTPN});
            this.barManager2.MainMenu = this.bar4;
            this.barManager2.MaxItemId = 4;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem_CTPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa_CTPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi_CTPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy_CTPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.StandaloneBarDockControl = this.standaloneBarDockControl2;
            this.bar4.Text = "Main menu";
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
            this.btnXoa_CTPN.Id = 1;
            this.btnXoa_CTPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_CTPN.ImageOptions.Image")));
            this.btnXoa_CTPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa_CTPN.ImageOptions.LargeImage")));
            this.btnXoa_CTPN.Name = "btnXoa_CTPN";
            this.btnXoa_CTPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_CTPN_ItemClick);
            // 
            // btnGhi_CTPN
            // 
            this.btnGhi_CTPN.Caption = "Ghi";
            this.btnGhi_CTPN.Enabled = false;
            this.btnGhi_CTPN.Id = 2;
            this.btnGhi_CTPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi_CTPN.ImageOptions.Image")));
            this.btnGhi_CTPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi_CTPN.ImageOptions.LargeImage")));
            this.btnGhi_CTPN.Name = "btnGhi_CTPN";
            this.btnGhi_CTPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_CTPN_ItemClick);
            // 
            // btnHuy_CTPN
            // 
            this.btnHuy_CTPN.Caption = "Hủy";
            this.btnHuy_CTPN.Enabled = false;
            this.btnHuy_CTPN.Id = 3;
            this.btnHuy_CTPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy_CTPN.ImageOptions.Image")));
            this.btnHuy_CTPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy_CTPN.ImageOptions.LargeImage")));
            this.btnHuy_CTPN.Name = "btnHuy_CTPN";
            this.btnHuy_CTPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_CTPN_ItemClick);
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
            this.barDockControl2.Location = new System.Drawing.Point(0, 450);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(800, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 450);
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // formPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "formPhieuXuat";
            this.Text = "Xuất hàng";
            this.Load += new System.EventHandler(this.formXuatHang_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia_CTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong_CTPX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DS DS;
     
        private System.Windows.Forms.BindingSource bdsPhieuXuat;
        private DSTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsChiTietPhieuXuat;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.TextBox txtMaPX;
        private System.Windows.Forms.TextBox txtMaVT_CTPX;
        private System.Windows.Forms.TextBox txtMaPX_CTPX;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem btnThem_CTPN;
        private DevExpress.XtraBars.BarButtonItem btnXoa_CTPN;
        private DevExpress.XtraBars.BarButtonItem btnGhi_CTPN;
        private DevExpress.XtraBars.BarButtonItem btnHuy_CTPN;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl2;
        private System.Windows.Forms.Button btnCancel_PN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraGrid.GridControl cTPXGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraGrid.GridControl phieuXuatGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private System.Windows.Forms.BindingSource bdsKho;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.ComboBox cbMaKho;
        private System.Windows.Forms.ComboBox cbMaVT_CTPX;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.Label lbThongTinVT;
        private System.Windows.Forms.NumericUpDown txtDonGia_CTPX;
        private System.Windows.Forms.NumericUpDown txtSoLuong_CTPX;
    }
}