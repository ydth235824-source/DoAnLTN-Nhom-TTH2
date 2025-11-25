using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAnMonHoc
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet("dsQLCH");
        SqlDataAdapter daDoanhThu;
        SqlConnection conn;
        SqlCommandBuilder cb;

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(
                @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLCH;Integrated Security=True");

            string query = "SELECT * FROM DoanhThu";

            daDoanhThu = new SqlDataAdapter(query, conn);
            cb = new SqlCommandBuilder(daDoanhThu);

            daDoanhThu.Fill(ds, "tblDSDoanhThu");

            dgvDoanhThu.DataSource = ds.Tables["tblDSDoanhThu"];

            FormatGrid();

        }

        private void FormatGrid()
        {
            dgvDoanhThu.Columns["MaDT"].HeaderText = "Mã Doanh Thu";
            dgvDoanhThu.Columns["MaDT"].Width = 170;

            dgvDoanhThu.Columns["MaHD"].HeaderText = "Mã HD";
            dgvDoanhThu.Columns["MaHD"].Width = 150;

            dgvDoanhThu.Columns["Ngay"].HeaderText = "Ngày";
            dgvDoanhThu.Columns["Ngay"].Width = 150;

            dgvDoanhThu.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvDoanhThu.Columns["TongTien"].Width = 150;

            dgvDoanhThu.Columns["GhiChu"].HeaderText = "Ghi Chú";
            dgvDoanhThu.Columns["GhiChu"].Width = 300;
        }

        private void ClearFields()
        {
            txtMaDT.Clear();
            txtMaHD.Clear();
            txtSoTien.Clear();
            txtGhiChu.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDT.Text.Trim() == "" || txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã doanh thu và mã hóa đơn ");
                return;
            }

            // ===== KIỂM TRA TRÙNG MÃ DT =====
            DataTable tbl = ds.Tables["tblDSDoanhThu"];
            string ma = txtMaDT.Text.Trim();

            bool trungMa = tbl.AsEnumerable()
                              .Any(r => r.RowState != DataRowState.Deleted &&
                                          r["MaDT"].ToString() == ma);

            if (trungMa)
            {
                MessageBox.Show("Mã doanh thu đã tồn tại!\nVui lòng nhập mã khác!");
                return;
            }

            // ===== THÊM MỚI =====
            DataRow row = tbl.NewRow();
            row["MaDT"] = txtMaDT.Text.Trim();
            row["MaHD"] = txtMaHD.Text.Trim();
            row["TongTien"] = txtSoTien.Text.Trim();
            row["GhiChu"] = txtGhiChu.Text.Trim();
            row["Ngay"] = dateNgay.Text.Trim();

            tbl.Rows.Add(row);

            MessageBox.Show("Đã thêm doanh thu!");
            ClearFields();
        }

        private void dgvDoanhThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // bỏ header

            DataGridViewRow row = dgvDoanhThu.Rows[e.RowIndex];

            txtMaDT.Text = row.Cells["MaDT"].Value?.ToString() ?? "";
            txtMaHD.Text = row.Cells["MaHD"].Value?.ToString() ?? "";
            txtSoTien.Text = row.Cells["TongTien"].Value?.ToString() ?? "";
            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["Ngay"].Value?.ToString(), out DateTime ngay))
                dateNgay.Value = ngay;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable tbl = ds.Tables["tblDSDoanhThu"];

            // Không có dữ liệu
            if (tbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa!");
                return;
            }

            // Chưa chọn dòng
            if (dgvDoanhThu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            int index = dgvDoanhThu.CurrentRow.Index;

            // Xác nhận
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa?",
                                               "Xác nhận",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // ❗ Xóa trên DataTable – không xóa trực tiếp trên DataGrid
                tbl.Rows[index].Delete();

                MessageBox.Show("Đã xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDoanhThu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }

            DataGridViewRow r = dgvDoanhThu.SelectedRows[0];

            r.Cells["MaDT"].Value = txtMaDT.Text.Trim();
            r.Cells["MaHD"].Value = txtMaHD.Text.Trim();
            r.Cells["Ngay"].Value = dateNgay.Value;
            r.Cells["TongTien"].Value = txtSoTien.Text.Trim();
            r.Cells["GhiChu"].Value = txtGhiChu.Text.Trim();

            MessageBox.Show("Đã sửa thành công!");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(
                    "ALTER TABLE DoanhThu NOCHECK CONSTRAINT ALL", conn);
                cmd1.ExecuteNonQuery();

                daDoanhThu.Update(ds.Tables["tblDSDoanhThu"]);

                SqlCommand cmd2 = new SqlCommand(
                    "ALTER TABLE DoanhThu CHECK CONSTRAINT ALL", conn);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Lưu dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu SQL: " + ex.Message);
            }
            finally
            {
                conn.Close();
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaDT.Clear();
            txtMaHD.Clear();
            txtGhiChu.Clear();
            txtSoTien.Clear();

            txtMaDT.Focus();
        }
    }
}
