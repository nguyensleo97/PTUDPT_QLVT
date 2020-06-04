namespace QLVT
{
    partial class formHoatDongNhanVien
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rdHangXuat = new System.Windows.Forms.RadioButton();
            this.rdHangNhap = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.txtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QLVT.DS();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLVT.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Chi nhánh:";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(143, 61);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(230, 21);
            this.cmbChiNhanh.TabIndex = 16;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(198, 251);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 23);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Xuất báo cáo";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rdHangXuat
            // 
            this.rdHangXuat.AutoSize = true;
            this.rdHangXuat.Location = new System.Drawing.Point(262, 206);
            this.rdHangXuat.Name = "rdHangXuat";
            this.rdHangXuat.Size = new System.Drawing.Size(76, 17);
            this.rdHangXuat.TabIndex = 13;
            this.rdHangXuat.TabStop = true;
            this.rdHangXuat.Text = "Hàng Xuất";
            this.rdHangXuat.UseVisualStyleBackColor = true;
            // 
            // rdHangNhap
            // 
            this.rdHangNhap.AutoSize = true;
            this.rdHangNhap.Location = new System.Drawing.Point(171, 206);
            this.rdHangNhap.Name = "rdHangNhap";
            this.rdHangNhap.Size = new System.Drawing.Size(80, 17);
            this.rdHangNhap.TabIndex = 14;
            this.rdHangNhap.TabStop = true;
            this.rdHangNhap.Text = "Hàng Nhập";
            this.rdHangNhap.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.Location = new System.Drawing.Point(143, 163);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(230, 20);
            this.txtNgayKetThuc.TabIndex = 9;
            this.txtNgayKetThuc.ValueChanged += new System.EventHandler(this.txtNgayKetThuc_ValueChanged);
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.Location = new System.Drawing.Point(143, 128);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(230, 20);
            this.txtNgayBatDau.TabIndex = 10;
            this.txtNgayBatDau.ValueChanged += new System.EventHandler(this.txtNgayBatDau_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "HOẠT ĐỘNG NHÂN VIÊN";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NhanVien";
            this.bdsNhanVien.DataSource = this.DS;
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
            // cbMaNV
            // 
            this.cbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(143, 96);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(53, 21);
            this.cbMaNV.TabIndex = 18;
            this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(202, 97);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(171, 20);
            this.txtTenNV.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mã NV:";
            // 
            // formHoatDongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 294);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rdHangXuat);
            this.Controls.Add(this.rdHangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNgayKetThuc);
            this.Controls.Add(this.txtNgayBatDau);
            this.Controls.Add(this.label1);
            this.Name = "formHoatDongNhanVien";
            this.Text = "Hoạt động nhân viên";
            this.Load += new System.EventHandler(this.formHoatDongNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton rdHangXuat;
        private System.Windows.Forms.RadioButton rdHangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtNgayKetThuc;
        private System.Windows.Forms.DateTimePicker txtNgayBatDau;
        private System.Windows.Forms.Label label1;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNV;
    }
}