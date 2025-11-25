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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter daKhachHang;
        SqlCommandBuilder cb;
        DataSet ds = new DataSet();

        

        private void FormatGrid()
        {
            dgvKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
            dgvKhachHang.Columns["MaKH"].Width = 70;

            dgvKhachHang.Columns["TenKH"].HeaderText = "Tên KH";
            dgvKhachHang.Columns["TenKH"].Width = 150;

            dgvKhachHang.Columns["SoDienThoai"].HeaderText = "Số ĐT";
            dgvKhachHang.Columns["SoDienThoai"].Width = 120;

            dgvKhachHang.Columns["Email"].HeaderText = "Email";
            dgvKhachHang.Columns["Email"].Width = 150;

            dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns["DiaChi"].Width = 120;

            dgvKhachHang.Columns["LoaiTaiKhoan"].HeaderText = "Loại TK";
            dgvKhachHang.Columns["LoaiTaiKhoan"].Width = 120;

            dgvKhachHang.Columns.Remove("MaTK");
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(
               @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLCH;Integrated Security=True");

            string query = "SELECT * FROM KhachHang";

            daKhachHang = new SqlDataAdapter(query, conn);

            // Tự động sinh Insert, Update, Delete
            cb = new SqlCommandBuilder(daKhachHang);

            daKhachHang.Fill(ds, "tblDSKhachHang");

            dgvKhachHang.DataSource = ds.Tables["tblDSKhachHang"];

            FormatGrid();
        }

        //xóa textbox
        private void ClearFields()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            cboDiaChi.SelectedIndex = -1;
            cboTaiKhoan.SelectedIndex = -1;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Không click vào header

            DataGridViewRow r = dgvKhachHang.Rows[e.RowIndex];

            txtMaKH.Text = r.Cells["MaKH"].Value?.ToString() ?? "";
            txtTenKH.Text = r.Cells["TenKH"].Value?.ToString() ?? "";
            txtSDT.Text = r.Cells["SoDienThoai"].Value?.ToString() ?? "";
            txtEmail.Text = r.Cells["Email"].Value?.ToString() ?? "";
            cboDiaChi.Text = r.Cells["DiaChi"].Value?.ToString() ?? "";
            cboTaiKhoan.Text = r.Cells["LoaiTaiKhoan"].Value?.ToString() ?? "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "" || txtTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã KH và Tên KH!");
                return;
            }

            // ===== KIỂM TRA TRÙNG MÃ KH =====
            DataTable tbl = ds.Tables["tblDSKhachHang"];
            string ma = txtMaKH.Text.Trim();

            bool trungMa = tbl.AsEnumerable()
                              .Any(r => r.RowState != DataRowState.Deleted &&
                                          r["MaKH"].ToString() == ma);

            if (trungMa)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!\nVui lòng nhập mã khác!");
                return;
            }

            // ===== THÊM MỚI =====
            DataRow row = tbl.NewRow();
            row["MaKH"] = txtMaKH.Text.Trim();
            row["TenKH"] = txtTenKH.Text.Trim();
            row["SoDienThoai"] = txtSDT.Text.Trim();
            row["Email"] = txtEmail.Text.Trim();
            row["DiaChi"] = cboDiaChi.Text.Trim();
            row["LoaiTaiKhoan"] = cboTaiKhoan.Text.Trim();

            tbl.Rows.Add(row);

            MessageBox.Show("Đã thêm khách hàng!");
            ClearFields();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            dgvKhachHang.Rows.RemoveAt(dgvKhachHang.SelectedRows[0].Index);
            MessageBox.Show("Đã xóa!");
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa!");
                return;
            }

            DataGridViewRow r = dgvKhachHang.SelectedRows[0];

            r.Cells["MaKH"].Value = txtMaKH.Text;
            r.Cells["TenKH"].Value = txtTenKH.Text;
            r.Cells["SoDienThoai"].Value = txtSDT.Text;
            r.Cells["Email"].Value = txtEmail.Text;
            r.Cells["DiaChi"].Value = cboDiaChi.Text;
            r.Cells["LoaiTaiKhoan"].Value = cboTaiKhoan.Text;

            MessageBox.Show("Đã sửa thông tin!");
            
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daKhachHang.Update(ds.Tables["tblDSKhachHang"]);
                MessageBox.Show("Lưu dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu SQL: " + ex.Message);
            }
            
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
