namespace DoAnMonHoc
{
    partial class frmDoanhThu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateNgay = new System.Windows.Forms.DateTimePicker();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(412, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Doanh Thu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateNgay);
            this.groupBox1.Controls.Add(this.txtSoTien);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.txtMaDT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // dateNgay
            // 
            this.dateNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgay.Location = new System.Drawing.Point(683, 27);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Size = new System.Drawing.Size(291, 35);
            this.dateNgay.TabIndex = 2;
            this.dateNgay.Value = new System.DateTime(2025, 11, 22, 0, 0, 0, 0);
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(397, 130);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(323, 35);
            this.txtSoTien.TabIndex = 1;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(683, 78);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(291, 35);
            this.txtGhiChu.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(199, 78);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(291, 35);
            this.txtMaHD.TabIndex = 1;
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(199, 27);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(291, 35);
            this.txtMaDT.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ghi Chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(587, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Doanh Thu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDoanhThu);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1015, 264);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(7, 35);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 62;
            this.dgvDoanhThu.RowTemplate.Height = 28;
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1002, 223);
            this.dgvDoanhThu.TabIndex = 0;
            this.dgvDoanhThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhThu_CellClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(700, 300);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(144, 48);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(523, 300);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 48);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(351, 300);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 48);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(178, 300);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 48);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(11, 300);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 48);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(882, 300);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(144, 48);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 634);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoanhThu";
            this.Text = "frmDoanhThu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNgay;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}