namespace DoAnMonHoc
{
    partial class frmDangNhap
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
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lbltendangnhap = new System.Windows.Forms.Label();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp1
            // 
            this.grp1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grp1.Controls.Add(this.txtTen);
            this.grp1.Controls.Add(this.txtMatKhau);
            this.grp1.Controls.Add(this.lbltendangnhap);
            this.grp1.Controls.Add(this.lblmatkhau);
            this.grp1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grp1.Location = new System.Drawing.Point(425, 66);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(404, 199);
            this.grp1.TabIndex = 17;
            this.grp1.TabStop = false;
            this.grp1.Text = "Đăng Nhập";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(199, 62);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 39);
            this.txtTen.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(199, 135);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(200, 39);
            this.txtMatKhau.TabIndex = 10;
            // 
            // lbltendangnhap
            // 
            this.lbltendangnhap.AutoSize = true;
            this.lbltendangnhap.Location = new System.Drawing.Point(7, 62);
            this.lbltendangnhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltendangnhap.Name = "lbltendangnhap";
            this.lbltendangnhap.Size = new System.Drawing.Size(196, 32);
            this.lbltendangnhap.TabIndex = 7;
            this.lbltendangnhap.Text = "Tên đăng nhập";
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Location = new System.Drawing.Point(7, 135);
            this.lblmatkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(131, 32);
            this.lblmatkhau.TabIndex = 8;
            this.lblmatkhau.Text = "Mật khẩu";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(658, 313);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(115, 56);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.Location = new System.Drawing.Point(451, 313);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(136, 56);
            this.btnDangNhap.TabIndex = 15;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnMonHoc.Properties.Resources.kk;
            this.pictureBox1.Location = new System.Drawing.Point(-11, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 397);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(835, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grp1;
        public System.Windows.Forms.TextBox txtTen;
        public System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lbltendangnhap;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDangNhap;
    }
}