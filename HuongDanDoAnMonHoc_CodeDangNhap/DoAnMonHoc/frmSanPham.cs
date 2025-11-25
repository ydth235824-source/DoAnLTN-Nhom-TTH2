using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMonHoc
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet("dsQLCH");
        SqlDataAdapter daSanPham;
        SqlConnection conn;
        SqlCommandBuilder cb;

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(
                @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLCH;Integrated Security=True");

            string query = "SELECT * FROM SanPham";

            daSanPham = new SqlDataAdapter(query, conn);
            cb = new SqlCommandBuilder(daSanPham);

            daSanPham.Fill(ds, "tblDSSanPham");

            dgvSanPham.DataSource = ds.Tables["tblDSSanPham"];

            FormatGrid();
        }

        private void FormatGrid()
        {
            dgvSanPham.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns["MaSP"].Width = 150;

            dgvSanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns["TenSP"].Width = 200;

            dgvSanPham.Columns["Gia"].HeaderText = "Giá Bán";
            dgvSanPham.Columns["Gia"].Width = 150;

            dgvSanPham.Columns["SoLuongTon"].HeaderText = "SL Tồn";
            dgvSanPham.Columns["SoLuongTon"].Width = 80;

            dgvSanPham.Columns["MauSac"].HeaderText = "Màu Sắc";
            dgvSanPham.Columns["MauSac"].Width = 150;

            dgvSanPham.Columns["SoSize"].HeaderText = "Size";
            dgvSanPham.Columns["SoSize"].Width = 80;

      
            dgvSanPham.Columns.Remove("MaSize");
        }



        private void btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
                string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(txtGiaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            DataTable tbl = ds.Tables["tblDSSanPham"];

            // kiểm tra trùng mã
            bool exists = tbl.AsEnumerable()
                .Any(r => r.Field<string>("MaSP")
                .Equals(txtMaSP.Text, StringComparison.OrdinalIgnoreCase));

            if (exists)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Lỗi");
                return;
            }

            DataRow row = tbl.NewRow();
            row["MaSP"] = txtMaSP.Text.Trim();
            row["TenSP"] = txtTenSP.Text.Trim();
            row["Gia"] = txtGiaBan.Text.Trim();
            row["SoLuongTon"] = txtSoLuongTon.Text.Trim();
            row["MauSac"] = cboMauSac.Text.Trim();
            row["SoSize"] = cboSize.Text.Trim();

            tbl.Rows.Add(row);

            MessageBox.Show("Đã thêm sản phẩm!", "Thành công");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DataTable tbl = ds.Tables["tblDSSanPham"];

            DataRow row = tbl.AsEnumerable()
                .FirstOrDefault(r => r["MaSP"].ToString() == txtMaSP.Text);

            if (row == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Lỗi");
                return;
            }

            row["TenSP"] = txtTenSP.Text.Trim();
            row["Gia"] = txtGiaBan.Text.Trim();
            row["SoLuongTon"] = txtSoLuongTon.Text.Trim();
            row["MauSac"] = cboMauSac.Text.Trim();
            row["SoSize"] = cboSize.Text.Trim();

            MessageBox.Show("Đã sửa!", "Thành công");
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu bấm vào header thì bỏ qua
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

            txtMaSP.Text = row.Cells["MaSP"].Value?.ToString();
            txtTenSP.Text = row.Cells["TenSP"].Value?.ToString();
            txtGiaBan.Text = row.Cells["Gia"].Value?.ToString();
            txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value?.ToString();
            cboMauSac.Text = row.Cells["MauSac"].Value?.ToString();
            cboSize.Text = row.Cells["SoSize"].Value?.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DataTable tbl = ds.Tables["tblDSSanPham"];

            DataRow row = tbl.AsEnumerable()
                .FirstOrDefault(r => r["MaSP"].ToString() == txtMaSP.Text);

            if (row != null)
            {
                row.Delete();
                MessageBox.Show("Đã xóa!", "Thành công");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                daSanPham.Update(ds.Tables["tblDSSanPham"]);
                MessageBox.Show("Đã lưu !", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaBan.Clear();
            txtSoLuongTon.Clear();
            cboMauSac.SelectedIndex = -1;
            cboSize.SelectedIndex = -1;

            txtMaSP.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?",
                                      "Xác nhận",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();   // CHỈ đóng form hiện tại
            }
        }
    }
}
