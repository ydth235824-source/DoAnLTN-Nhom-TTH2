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
    public partial class frmNhap : Form
    {
        public frmNhap()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter daPhieuNhap;
        SqlCommandBuilder cb;
        DataSet ds = new DataSet();


        private void frmNhap_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(
               @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLCH;Integrated Security=True");

            string query = "SELECT * FROM PhieuNhap";

            daPhieuNhap = new SqlDataAdapter(query, conn);

            // Tự động sinh Insert, Update, Delete
            cb = new SqlCommandBuilder(daPhieuNhap);

            daPhieuNhap.Fill(ds, "tblDSPhieuNhap");

            dgvPhieuNhap.DataSource = ds.Tables["tblDSPhieuNhap"];

            FormatGrid();

            
        }

        private void FormatGrid()
        {
            dgvPhieuNhap.Columns["MaPN"].HeaderText = "Mã Phiếu Nhập";
            dgvPhieuNhap.Columns["MaPN"].Width = 170;

            dgvPhieuNhap.Columns["MaSP"].HeaderText = "Mã SP";
            dgvPhieuNhap.Columns["MaSP"].Width = 100;

            dgvPhieuNhap.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvPhieuNhap.Columns["TongTien"].Width = 150;

            dgvPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            dgvPhieuNhap.Columns["NgayNhap"].Width = 150;

            dgvPhieuNhap.Columns["GhiChu"].HeaderText = "Ghi Chú";
            dgvPhieuNhap.Columns["GhiChu"].Width = 250;

            dgvPhieuNhap.Columns["SoLuongNhap"].HeaderText = "SL";
            dgvPhieuNhap.Columns["SoluongNhap"].Width = 100;

        }




        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            dgvPhieuNhap.Rows.RemoveAt(dgvPhieuNhap.SelectedRows[0].Index);
            MessageBox.Show("Đã xóa!");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daPhieuNhap.Update(ds.Tables["tblDSPhieuNhap"]);
                MessageBox.Show("Lưu dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu SQL: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa!");
                return;
            }

            DataGridViewRow r = dgvPhieuNhap.SelectedRows[0];

            r.Cells["MaPN"].Value = txtMaPN.Text;
            r.Cells["MaSP"].Value = txtMaSP.Text;
            r.Cells["TongTien"].Value = txtTongTien.Text;
            r.Cells["GhiChu"].Value = txtGhiChu.Text;
            r.Cells["NgayNhap"].Value =dtpNgayNhap.Text;
            r.Cells["SoLuongNhap"].Value = txtSoLuong.Text;


            MessageBox.Show("Đã sửa thông tin!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaPN.Clear();
            txtMaSP.Clear();
            txtGhiChu.Clear();
            txtTongTien.Clear();
            txtSoLuong.Clear();
            

            txtMaPN.Focus();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text.Trim() == "" || txtMaSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Mã PN và Mã SP!");
                return;
            }

            // ===== KIỂM TRA TRÙNG MÃ PN =====
            DataTable tbl = ds.Tables["tblDSPhieuNhap"];
            string ma = txtMaPN.Text.Trim();

            bool trungMa = tbl.AsEnumerable()
                              .Any(r => r.RowState != DataRowState.Deleted &&
                                          r["MaPN"].ToString() == ma);

            if (trungMa)
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại!\nVui lòng nhập mã khác!");
                return;
            }

            // ===== THÊM MỚI =====
            DataRow row = tbl.NewRow();
            row["MaPN"] = txtMaPN.Text.Trim();
            row["MaSP"] = txtMaSP.Text.Trim();
            row["TongTien"] = txtTongTien.Text.Trim();
            row["GhiChu"] = txtGhiChu.Text.Trim();
            row["NgayNhap"] = dtpNgayNhap.Text.Trim();
            row["SoLuongNhap"] = txtSoLuong.Text.Trim();

            tbl.Rows.Add(row);

            MessageBox.Show("Đã thêm phiếu nhập!");
            ClearFields();
        }

        //xóa textbox
        private void ClearFields()
        {
            txtMaPN.Clear();
            txtMaSP.Clear();
            txtTongTien.Clear();
            txtGhiChu.Clear();
            txtSoLuong.Clear();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow r = dgvPhieuNhap.Rows[e.RowIndex];

            txtMaPN.Text = r.Cells["MaPN"].Value?.ToString() ?? "";
            txtMaSP.Text = r.Cells["MaSP"].Value?.ToString() ?? "";
            txtTongTien.Text = r.Cells["TongTien"].Value?.ToString() ?? "";
            txtGhiChu.Text = r.Cells["GhiChu"].Value?.ToString() ?? "";
            txtSoLuong.Text = r.Cells["SoLuongNhap"].Value?.ToString() ?? "";
            dtpNgayNhap.Text = r.Cells["NgayNhap"].Value?.ToString() ?? "";
        }
    }
}
