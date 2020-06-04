namespace QLVT
{
    partial class formBangKetNhapXuat
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdHangNhap = new System.Windows.Forms.RadioButton();
            this.rdHangXuat = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ ";
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.Location = new System.Drawing.Point(174, 82);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(200, 20);
            this.txtNgayBatDau.TabIndex = 1;
            this.txtNgayBatDau.ValueChanged += new System.EventHandler(this.txtNgayBatDau_ValueChanged);
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.Location = new System.Drawing.Point(174, 117);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(200, 20);
            this.txtNgayKetThuc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // rdHangNhap
            // 
            this.rdHangNhap.AutoSize = true;
            this.rdHangNhap.Location = new System.Drawing.Point(147, 160);
            this.rdHangNhap.Name = "rdHangNhap";
            this.rdHangNhap.Size = new System.Drawing.Size(80, 17);
            this.rdHangNhap.TabIndex = 3;
            this.rdHangNhap.TabStop = true;
            this.rdHangNhap.Text = "Hàng Nhập";
            this.rdHangNhap.UseVisualStyleBackColor = true;
            // 
            // rdHangXuat
            // 
            this.rdHangXuat.AutoSize = true;
            this.rdHangXuat.Location = new System.Drawing.Point(238, 160);
            this.rdHangXuat.Name = "rdHangXuat";
            this.rdHangXuat.Size = new System.Drawing.Size(76, 17);
            this.rdHangXuat.TabIndex = 3;
            this.rdHangXuat.TabStop = true;
            this.rdHangXuat.Text = "Hàng Xuất";
            this.rdHangXuat.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(174, 205);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Xuất báo cáo";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "HÀNG NHẬP HOẶC XUẤT";
            // 
            // formBangKetNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 271);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rdHangXuat);
            this.Controls.Add(this.rdHangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNgayKetThuc);
            this.Controls.Add(this.txtNgayBatDau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "formBangKetNhapXuat";
            this.Text = "Bảng kê nhập xuất";
            this.Load += new System.EventHandler(this.formBangKetNhapXuat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtNgayBatDau;
        private System.Windows.Forms.DateTimePicker txtNgayKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdHangNhap;
        private System.Windows.Forms.RadioButton rdHangXuat;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label4;
    }
}