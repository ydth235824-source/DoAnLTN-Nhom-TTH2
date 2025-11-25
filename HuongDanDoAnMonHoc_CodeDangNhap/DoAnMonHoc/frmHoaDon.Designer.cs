namespace DoAnMonHoc
{
    partial class frmHoaDon
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
            this.cboPTTT = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPTTT
            // 
            this.cboPTTT.FormattingEnabled = true;
            this.cboPTTT.Items.AddRange(new object[] {
            "Chuyển Khoản",
            "Tiền Mặt",
            "Thẻ"});
            this.cboPTTT.Location = new System.Drawing.Point(377, 151);
            this.cboPTTT.Name = "cboPTTT";
            this.cboPTTT.Size = new System.Drawing.Size(150, 35);
            this.cboPTTT.TabIndex = 28;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(613, 238);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 37);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(414, 238);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(132, 37);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(209, 238);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 37);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(8, 238);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 37);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 317);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(921, 281);
            this.dgvHoaDon.TabIndex = 23;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(354, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(391, 41);
            this.label7.TabIndex = 22;
            this.label7.Text = "HÓA ĐƠN CỬA HÀNG";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(694, 89);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(200, 35);
            this.dtpNgayBan.TabIndex = 21;
            this.dtpNgayBan.Value = new System.DateTime(2025, 11, 20, 0, 0, 0, 0);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(694, 148);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 35);
            this.txtTongTien.TabIndex = 20;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(377, 89);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(150, 35);
            this.txtMaSP.TabIndex = 19;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(107, 148);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(150, 35);
            this.txtMaHD.TabIndex = 18;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(107, 88);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(150, 35);
            this.txtMaKH.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tổng Tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày Bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "PTTT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã HĐ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã KH:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(807, 238);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 37);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 619);
            this.Controls.Add(this.cboPTTT);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgayBan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPTTT;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}