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
using System.Xml;

namespace DoAnMonHoc
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("dsQLCH");
        SqlDataAdapter daHoaDon;
        SqlConnection conn;
        SqlCommandBuilder cb;

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(
                @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLCH;Integrated Security=True");

            string query = "SELECT * FROM HoaDon";

            daHoaDon = new SqlDataAdapter(query, conn);
            cb = new SqlCommandBuilder(daHoaDon);

            daHoaDon.Fill(ds, "tblDSHoaDon");

            dgvHoaDon.DataSource = ds.Tables["tblDSHoaDon"];

            FormatGrid();
        }

        private void FormatGrid()
        {
            dgvHoaDon.Columns["MaKH"].HeaderText = "Mã KH";
            dgvHoaDon.Columns["MaKH"].Width = 140;

            dgvHoaDon.Columns["MaHD"].HeaderText = "Mã HD";
            dgvHoaDon.Columns["MaHD"].Width = 140;

            dgvHoaDon.Columns["MaSP"].HeaderText = "Mã SP";
            dgvHoaDon.Columns["MaSP"].Width = 140;

            dgvHoaDon.Columns["PhuongThucThanhToan"].HeaderText = "PTTT";
            dgvHoaDon.Columns["PhuongThucThanhToan"].Width = 150;

            dgvHoaDon.Columns["NgayBan"].HeaderText = "Ngày Bán";
            dgvHoaDon   .Columns["NgayBan"].Width = 150;

            dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvHoaDon.Columns["TongTien"].Width = 150;

            //dgvHoaDon.Columns.Remove("MaTK");
        }

        private void ClearFields()
        {
            txtMaKH.Clear();
            txtMaHD.Clear();
            txtMaSP.Clear();
            txtTongTien.Clear();
            cboPTTT.SelectedIndex = -1;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Không click vào header

            DataGridViewRow r = dgvHoaDon.Rows[e.RowIndex];

            txtMaKH.Text = r.Cells["MaKH"].Value?.ToString() ?? "";
            txtMaHD.Text = r.Cells["MaHD"].Value?.ToString() ?? "";
            txtMaSP.Text = r.Cells["MaSP"].Value?.ToString() ?? "";
            txtTongTien.Text = r.Cells["TongTien"].Value?.ToString() ?? "";
            cboPTTT.Text = r.Cells["PhuongThucThanhToan"].Value?.ToString() ?? "";
            dtpNgayBan.Text = r.Cells["NgayBan"].Value?.ToString() ?? "";
        }


        

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "" || txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã KH và Mã HD!");
                return;
            }

            DataTable tbl = ds.Tables["tblDSHoaDon"];
            string ma = txtMaHD.Text.Trim();

            bool trungMa = tbl.AsEnumerable()
                              .Any(r => r.RowState != DataRowState.Deleted &&
                                          r["MaHD"].ToString() == ma);

            if (trungMa)
            {
                MessageBox.Show("Mã HD đã tồn tại!\nVui lòng nhập mã khác!");
                return;
            }

            DataRow row = tbl.NewRow();
            row["MaKH"] = txtMaKH.Text.Trim();
            row["MaHD"] = txtMaHD.Text.Trim();
            row["MaSP"] = txtMaSP.Text.Trim();
            row["TongTien"] = txtTongTien.Text.Trim();
            row["PhuongThucThanhToan"] = cboPTTT.Text.Trim();
            row["NgayBan"] = dtpNgayBan.Value;

            tbl.Rows.Add(row);

            MessageBox.Show("Đã thêm hóa đơn!");
            ClearFields();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            string maHDChon = dgvHoaDon.SelectedRows[0].Cells["MaHD"].Value.ToString();

            DataTable tbl = ds.Tables["tblDSHoaDon"];
            DataRow row = tbl.AsEnumerable()
                             .FirstOrDefault(r => r["MaHD"].ToString() == maHDChon);

            if (row != null)
            {
                row.Delete();  // Đánh dấu xóa trong DataSet
                MessageBox.Show("Đã xóa hóa đơn!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn để xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để sửa!");
                return;
            }

            // Lấy mã hóa đơn của dòng được chọn
            string maHDChon = dgvHoaDon.SelectedRows[0].Cells["MaHD"].Value.ToString();

            // Tìm row trong DataSet theo MaHD
            DataTable tbl = ds.Tables["tblDSHoaDon"];
            DataRow row = tbl.AsEnumerable()
                             .FirstOrDefault(r => r["MaHD"].ToString() == maHDChon);

            if (row != null)
            {
                row["MaKH"] = txtMaKH.Text.Trim();
                row["MaSP"] = txtMaSP.Text.Trim();
                row["TongTien"] = txtTongTien.Text.Trim();
                row["PhuongThucThanhToan"] = cboPTTT.Text.Trim();
                row["NgayBan"] = dtpNgayBan.Value;
                MessageBox.Show("Đã sửa hóa đơn!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn để sửa!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(
                    "ALTER TABLE HoaDon NOCHECK CONSTRAINT ALL", conn);
                cmd1.ExecuteNonQuery();

                daHoaDon.Update(ds.Tables["tblDSHoaDon"]);

                SqlCommand cmd2 = new SqlCommand(
                    "ALTER TABLE HoaDon CHECK CONSTRAINT ALL", conn);
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
    }
}
