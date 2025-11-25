namespace DoAnMonHoc
{
    partial class frmSanPham
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
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblsoluongton = new System.Windows.Forms.Label();
            this.lblgiaban = new System.Windows.Forms.Label();
            this.lbltensp = new System.Windows.Forms.Label();
            this.lblmasp = new System.Windows.Forms.Label();
            this.lblqlsp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMauSac = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSanPham.Location = new System.Drawing.Point(74, 366);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(891, 226);
            this.dgvSanPham.TabIndex = 39;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhuy.Location = new System.Drawing.Point(672, 292);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(122, 50);
            this.btnhuy.TabIndex = 37;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluu.Location = new System.Drawing.Point(504, 292);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(117, 50);
            this.btnluu.TabIndex = 36;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Location = new System.Drawing.Point(357, 292);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(104, 50);
            this.btnxoa.TabIndex = 35;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Location = new System.Drawing.Point(202, 292);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(108, 50);
            this.btnsua.TabIndex = 34;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Location = new System.Drawing.Point(61, 292);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(105, 50);
            this.btnthem.TabIndex = 33;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(690, 205);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(287, 35);
            this.txtSoLuongTon.TabIndex = 30;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaBan.Location = new System.Drawing.Point(197, 205);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(268, 35);
            this.txtGiaBan.TabIndex = 29;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSP.Location = new System.Drawing.Point(197, 145);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(268, 35);
            this.txtTenSP.TabIndex = 28;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSP.Location = new System.Drawing.Point(197, 86);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(268, 35);
            this.txtMaSP.TabIndex = 27;
            // 
            // lblsoluongton
            // 
            this.lblsoluongton.AutoSize = true;
            this.lblsoluongton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblsoluongton.Location = new System.Drawing.Point(529, 205);
            this.lblsoluongton.Name = "lblsoluongton";
            this.lblsoluongton.Size = new System.Drawing.Size(141, 26);
            this.lblsoluongton.TabIndex = 26;
            this.lblsoluongton.Text = "Số lượng tồn";
            // 
            // lblgiaban
            // 
            this.lblgiaban.AutoSize = true;
            this.lblgiaban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblgiaban.Location = new System.Drawing.Point(36, 205);
            this.lblgiaban.Name = "lblgiaban";
            this.lblgiaban.Size = new System.Drawing.Size(93, 26);
            this.lblgiaban.TabIndex = 25;
            this.lblgiaban.Text = "Giá bán";
            // 
            // lbltensp
            // 
            this.lbltensp.AutoSize = true;
            this.lbltensp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltensp.Location = new System.Drawing.Point(36, 145);
            this.lbltensp.Name = "lbltensp";
            this.lbltensp.Size = new System.Drawing.Size(154, 26);
            this.lbltensp.TabIndex = 24;
            this.lbltensp.Text = "Tên sản phẩm";
            // 
            // lblmasp
            // 
            this.lblmasp.AutoSize = true;
            this.lblmasp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblmasp.Location = new System.Drawing.Point(36, 89);
            this.lblmasp.Name = "lblmasp";
            this.lblmasp.Size = new System.Drawing.Size(150, 26);
            this.lblmasp.TabIndex = 23;
            this.lblmasp.Text = "Mã sản phẩm";
            // 
            // lblqlsp
            // 
            this.lblqlsp.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblqlsp.Location = new System.Drawing.Point(405, 15);
            this.lblqlsp.Name = "lblqlsp";
            this.lblqlsp.Size = new System.Drawing.Size(433, 54);
            this.lblqlsp.TabIndex = 22;
            this.lblqlsp.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(607, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Size";
            // 
            // cboSize
            // 
            this.cboSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cboSize.Location = new System.Drawing.Point(690, 83);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(287, 35);
            this.cboSize.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(568, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Màu Sắc";
            // 
            // cboMauSac
            // 
            this.cboMauSac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMauSac.FormattingEnabled = true;
            this.cboMauSac.Items.AddRange(new object[] {
            "Trắng",
            "Đen ",
            "Đỏ",
            "Nâu",
            "Tím",
            "Hồng"});
            this.cboMauSac.Location = new System.Drawing.Point(690, 142);
            this.cboMauSac.Name = "cboMauSac";
            this.cboMauSac.Size = new System.Drawing.Size(287, 35);
            this.cboMauSac.TabIndex = 41;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(832, 292);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 50);
            this.btnThoat.TabIndex = 37;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 601);
            this.Controls.Add(this.cboMauSac);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblsoluongton);
            this.Controls.Add(this.lblgiaban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltensp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmasp);
            this.Controls.Add(this.lblqlsp);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblsoluongton;
        private System.Windows.Forms.Label lblgiaban;
        private System.Windows.Forms.Label lbltensp;
        private System.Windows.Forms.Label lblmasp;
        private System.Windows.Forms.Label lblqlsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMauSac;
        private System.Windows.Forms.Button btnThoat;
    }
}