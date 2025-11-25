namespace DoAnMonHoc
{
    partial class frmKhachHang
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDiaChi = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.cboTaiKhoan = new System.Windows.Forms.ComboBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 378);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(783, 298);
            this.dgvKhachHang.TabIndex = 13;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.cboDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.cboTaiKhoan);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(16, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 196);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // cboDiaChi
            // 
            this.cboDiaChi.FormattingEnabled = true;
            this.cboDiaChi.Items.AddRange(new object[] {
            "AN GIANG",
            "TP HCM",
            "ĐỒNG THÁP",
            "VĨNH LONG",
            "CẦN THƠ"});
            this.cboDiaChi.Location = new System.Drawing.Point(482, 94);
            this.cboDiaChi.Name = "cboDiaChi";
            this.cboDiaChi.Size = new System.Drawing.Size(220, 35);
            this.cboDiaChi.TabIndex = 6;
            // 
            // txtSDT
            // 
            this.txtSDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSDT.Location = new System.Drawing.Point(145, 86);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(175, 35);
            this.txtSDT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Điện Thoại:\r\n";
            // 
            // txtMaKH
            // 
            this.txtMaKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaKH.Location = new System.Drawing.Point(145, 35);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(175, 35);
            this.txtMaKH.TabIndex = 1;
            // 
            // cboTaiKhoan
            // 
            this.cboTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboTaiKhoan.FormattingEnabled = true;
            this.cboTaiKhoan.Items.AddRange(new object[] {
            "KHM",
            "VIP"});
            this.cboTaiKhoan.Location = new System.Drawing.Point(482, 147);
            this.cboTaiKhoan.Name = "cboTaiKhoan";
            this.cboTaiKhoan.Size = new System.Drawing.Size(220, 35);
            this.cboTaiKhoan.TabIndex = 5;
            // 
            // txtTenKH
            // 
            this.txtTenKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenKH.Location = new System.Drawing.Point(482, 35);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(265, 35);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.Location = new System.Drawing.Point(145, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 35);
            this.txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(340, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại Tài Khoản:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(340, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên KH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(14, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Emai:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(340, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(509, 310);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 37);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(343, 310);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(132, 37);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(175, 310);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 37);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 310);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 37);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(217, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(546, 51);
            this.label7.TabIndex = 0;
            this.label7.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(669, 310);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 37);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 679);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.ComboBox cboTaiKhoan;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
    }
}