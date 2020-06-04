namespace QLVT
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnINDSNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.pnChiNhanh = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.DS = new QLVT.DS();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLVT.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTrangThaiXoa = new DevExpress.XtraEditors.SpinEdit();
            this.txtMACN = new DevExpress.XtraEditors.TextEdit();
            this.txtLUONG = new DevExpress.XtraEditors.SpinEdit();
            this.txtNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.txtDIACHI = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.pnChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThaiXoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLUONG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYSINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(71, 35);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(59, 19);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MANV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(320, 35);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(35, 19);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(512, 35);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(42, 19);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(71, 84);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(66, 19);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(461, 84);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(93, 19);
            nGAYSINHLabel.TabIndex = 8;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Location = new System.Drawing.Point(70, 132);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(67, 19);
            lUONGLabel.TabIndex = 10;
            lUONGLabel.Text = "LUONG:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(311, 132);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(60, 19);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "MACN:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(541, 132);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(106, 19);
            trangThaiXoaLabel.TabIndex = 14;
            trangThaiXoaLabel.Text = "Trang Thai Xoa:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnRefresh,
            this.btnChuyenChiNhanh,
            this.btnThoat,
            this.btnGhi,
            this.barButtonItem1,
            this.btnINDSNV,
            this.btnTaoLogin});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChuyenChiNhanh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnINDSNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaoLogin, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::QLVT.Properties.Resources.Teacher_male_icon_24;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = global::QLVT.Properties.Resources.Text_Edit_icon_24;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 7;
            this.btnGhi.ImageOptions.Image = global::QLVT.Properties.Resources.Save_icon_24;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = global::QLVT.Properties.Resources.Delete_2_icon_24;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Enabled = false;
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.Image = global::QLVT.Properties.Resources.Undo_icon_24;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.Image = global::QLVT.Properties.Resources.Button_Refresh_icon_24;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnChuyenChiNhanh
            // 
            this.btnChuyenChiNhanh.Caption = "Chuyển chi nhánh";
            this.btnChuyenChiNhanh.Id = 5;
            this.btnChuyenChiNhanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenChiNhanh.ImageOptions.Image")));
            this.btnChuyenChiNhanh.Name = "btnChuyenChiNhanh";
            this.btnChuyenChiNhanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenChiNhanh_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = global::QLVT.Properties.Resources.Exit_24_icon;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnINDSNV
            // 
            this.btnINDSNV.Caption = "In danh sách nhân viên";
            this.btnINDSNV.Id = 9;
            this.btnINDSNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnINDSNV.ImageOptions.Image")));
            this.btnINDSNV.Name = "btnINDSNV";
            this.btnINDSNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
            // 
            // btnTaoLogin
            // 
            this.btnTaoLogin.Caption = "Tạo Login";
            this.btnTaoLogin.Id = 10;
            this.btnTaoLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoLogin.ImageOptions.Image")));
            this.btnTaoLogin.Name = "btnTaoLogin";
            this.btnTaoLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoLogin_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(997, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 541);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(997, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 541);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(997, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 541);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Chuyển chi nhánh";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // pnChiNhanh
            // 
            this.pnChiNhanh.Controls.Add(this.label1);
            this.pnChiNhanh.Controls.Add(this.cmbChiNhanh);
            this.pnChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChiNhanh.Location = new System.Drawing.Point(0, 0);
            this.pnChiNhanh.Name = "pnChiNhanh";
            this.pnChiNhanh.Size = new System.Drawing.Size(997, 64);
            this.pnChiNhanh.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(324, 17);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(200, 27);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.DS;
            this.bdsNV.CurrentChanged += new System.EventHandler(this.bdsNV_CurrentChanged);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.bdsNV;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 64);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(997, 178);
            this.nhanVienGridControl.TabIndex = 6;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa,
            this.colrowguid});
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "HỌ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "TÊN";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "ĐỊA CHỈ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "NGÀY SINH";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colLUONG
            // 
            this.colLUONG.Caption = "LƯƠNG";
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.OptionsColumn.AllowEdit = false;
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "MÃ CN";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.OptionsColumn.AllowEdit = false;
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.Name = "colrowguid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(trangThaiXoaLabel);
            this.groupBox1.Controls.Add(this.txtTrangThaiXoa);
            this.groupBox1.Controls.Add(mACNLabel);
            this.groupBox1.Controls.Add(this.txtMACN);
            this.groupBox1.Controls.Add(lUONGLabel);
            this.groupBox1.Controls.Add(this.txtLUONG);
            this.groupBox1.Controls.Add(nGAYSINHLabel);
            this.groupBox1.Controls.Add(this.txtNGAYSINH);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.txtDIACHI);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtTEN);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.txtHO);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(this.txtMANV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 299);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(315, 175);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 37);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Cancel";
            this.btnHuy.UseMnemonic = false;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTrangThaiXoa
            // 
            this.txtTrangThaiXoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TrangThaiXoa", true));
            this.txtTrangThaiXoa.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTrangThaiXoa.Enabled = false;
            this.txtTrangThaiXoa.Location = new System.Drawing.Point(653, 133);
            this.txtTrangThaiXoa.MenuManager = this.barManager1;
            this.txtTrangThaiXoa.Name = "txtTrangThaiXoa";
            // 
            // 
            // 
            this.txtTrangThaiXoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTrangThaiXoa.Size = new System.Drawing.Size(45, 20);
            this.txtTrangThaiXoa.TabIndex = 15;
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MACN", true));
            this.txtMACN.Enabled = false;
            this.txtMACN.Location = new System.Drawing.Point(377, 133);
            this.txtMACN.MenuManager = this.barManager1;
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.TabIndex = 13;
            // 
            // txtLUONG
            // 
            this.txtLUONG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "LUONG", true));
            this.txtLUONG.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtLUONG.Location = new System.Drawing.Point(143, 133);
            this.txtLUONG.MenuManager = this.barManager1;
            this.txtLUONG.Name = "txtLUONG";
            // 
            // 
            // 
            this.txtLUONG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLUONG.TabIndex = 11;
            // 
            // txtNGAYSINH
            // 
            this.txtNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "NGAYSINH", true));
            this.txtNGAYSINH.Location = new System.Drawing.Point(560, 85);
            this.txtNGAYSINH.MenuManager = this.barManager1;
            this.txtNGAYSINH.Name = "txtNGAYSINH";
            // 
            // 
            // 
            this.txtNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.txtNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNGAYSINH.TabIndex = 9;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(143, 85);
            this.txtDIACHI.MenuManager = this.barManager1;
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(298, 20);
            this.txtDIACHI.TabIndex = 7;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(560, 36);
            this.txtTEN.MenuManager = this.barManager1;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.TabIndex = 5;
            this.txtTEN.EditValueChanged += new System.EventHandler(this.tENTextEdit_EditValueChanged);
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(357, 36);
            this.txtHO.MenuManager = this.barManager1;
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(149, 20);
            this.txtHO.TabIndex = 3;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(143, 34);
            this.txtMANV.MenuManager = this.barManager1;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.TabIndex = 1;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "FK_PhieuNhap_NhanVien";
            this.bdsPN.DataSource = this.bdsNV;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nhanVienGridControl);
            this.Controls.Add(this.pnChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "Nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.pnChiNhanh.ResumeLayout(false);
            this.pnChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThaiXoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLUONG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNGAYSINH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnChuyenChiNhanh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsNV;
        private DS DS;
        private System.Windows.Forms.Panel pnChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.TextEdit txtHO;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraEditors.TextEdit txtMACN;
        private DevExpress.XtraEditors.SpinEdit txtLUONG;
        private DevExpress.XtraEditors.DateEdit txtNGAYSINH;
        private DevExpress.XtraEditors.TextEdit txtDIACHI;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private System.Windows.Forms.BindingSource bdsPN;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.SpinEdit txtTrangThaiXoa;
        private DevExpress.XtraBars.BarButtonItem btnINDSNV;
        private DevExpress.XtraBars.BarButtonItem btnTaoLogin;
        private System.Windows.Forms.Button btnHuy;
    }
}