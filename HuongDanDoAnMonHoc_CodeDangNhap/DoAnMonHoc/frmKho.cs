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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace DoAnMonHoc
{
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet("dsQLCH");
        SqlDataAdapter daKho;

        void ClearFields()
        {
            txtMaSP.Clear();
            txtTen.Clear();
            txtSLTon.Clear();
            txtTGTon.Clear();
            txtCanhBao.Clear();
            cboKM.SelectedIndex = 0;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtMaSP.Text == "" || txtTen.Text == "" || txtSLTon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra trùng mã SP
                string check = "SELECT COUNT(*) FROM Kho WHERE MaSP = @MaSP";
                SqlCommand c1 = new SqlCommand(check, conn);
                c1.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());

                if ((int)c1.ExecuteScalar() > 0)
                {
                    MessageBox.Show("❌ Mã sản phẩm đã tồn tại, không thể thêm!");
                    return;
                }

                string query = @"INSERT INTO Kho (MaSP, TenSP, SLTon, ThoiGianTon, CanhBao, KM)
                         VALUES (@MaSP, @TenSP, @SLTon, @ThoiGianTon, @CanhBao, @KM)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());
                cmd.Parameters.AddWithValue("@TenSP", txtTen.Text.Trim());
                cmd.Parameters.AddWithValue("@SLTon", int.Parse(txtSLTon.Text));
                cmd.Parameters.AddWithValue("@ThoiGianTon", txtTGTon.Text.Trim());
                cmd.Parameters.AddWithValue("@CanhBao", txtCanhBao.Text.Trim());
                cmd.Parameters.AddWithValue("@KM", cboKM.Text.Trim());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadKho();
                ClearFields();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            UPDATE Kho 
            SET 
                TenSP = @TenSP,
                SLTon = @SLTon,
                ThoiGianTon = @ThoiGianTon,
                CanhBao = @CanhBao,
                KM = @KM
            WHERE MaSP = @MaSP";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                cmd.Parameters.AddWithValue("@TenSP", txtTen.Text);
                cmd.Parameters.AddWithValue("@SLTon", txtSLTon.Text);
                cmd.Parameters.AddWithValue("@ThoiGianTon", txtTGTon.Text);
                cmd.Parameters.AddWithValue("@CanhBao", txtCanhBao.Text);
                cmd.Parameters.AddWithValue("@KM", cboKM.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadKho();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("❌ Sửa thất bại!\nKiểm tra lại MaSP hoặc chưa chọn dòng.");
                }
            }
        }

      
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "" || txtTen.Text == "" || txtSLTon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra MaSP đã tồn tại chưa
                string checkQuery = "SELECT COUNT(*) FROM Kho WHERE MaSP = @MaSP";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0) // Nếu tồn tại → UPDATE
                {
                    string updateQuery = @"
                UPDATE Kho 
                SET TenSP = @TenSP,
                    SLTon = @SLTon,
                    ThoiGianTon = @TGTon,
                    CanhBao = @CanhBao,
                    KM = @KM
                WHERE MaSP = @MaSP";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("@TenSP", txtTen.Text);
                    cmd.Parameters.AddWithValue("@SLTon", txtSLTon.Text);
                    cmd.Parameters.AddWithValue("@TGTon", txtTGTon.Text);
                    cmd.Parameters.AddWithValue("@CanhBao", txtCanhBao.Text);
                    cmd.Parameters.AddWithValue("@KM", cboKM.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Cập nhật thành công!");
                }
                else // Nếu chưa tồn tại → INSERT
                {
                    string insertQuery = @"
                INSERT INTO Kho (MaSP, TenSP, SLTon, ThoiGianTon, CanhBao, KM)
                VALUES (@MaSP, @TenSP, @SLTon, @TGTon, @CanhBao, @KM)";

                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                    cmd.Parameters.AddWithValue("@TenSP", txtTen.Text);
                    cmd.Parameters.AddWithValue("@SLTon", txtSLTon.Text);
                    cmd.Parameters.AddWithValue("@TGTon", txtTGTon.Text);
                    cmd.Parameters.AddWithValue("@CanhBao", txtCanhBao.Text);
                    cmd.Parameters.AddWithValue("@KM", cboKM.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }

                LoadKho(); // Load lại ListView sau khi lưu
                ClearFields(); // Xóa dữ liệu TextBox
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Kho WHERE MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                LoadKho();
                ClearFields();

                conn.Close();
            }
        }

        string connectionString = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLCH;Integrated Security=True";


        private void frmKho_Load(object sender, EventArgs e)
        {
            LoadKho();
        }

        void LoadKho()
        {
            lstKho.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Kho";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    ListViewItem item = new ListViewItem(rd["MaSP"].ToString());
                    item.SubItems.Add(rd["TenSP"].ToString());
                    item.SubItems.Add(rd["SLTon"].ToString());
                    item.SubItems.Add(rd["ThoiGianTon"].ToString());
                    item.SubItems.Add(rd["CanhBao"].ToString());
                    item.SubItems.Add(rd["KM"].ToString());
                    lstKho.Items.Add(item);
                }

                conn.Close();
            }
        }

        private void lstKho_Click(object sender, EventArgs e)
        {
            if (lstKho.SelectedItems.Count > 0)
            {
                ListViewItem item = lstKho.SelectedItems[0];

                txtMaSP.Text = item.SubItems[0].Text;
                txtTen.Text = item.SubItems[1].Text;
                txtSLTon.Text = item.SubItems[2].Text;
                txtTGTon.Text = item.SubItems[3].Text;
                txtCanhBao.Text = item.SubItems[4].Text;
                cboKM.Text = item.SubItems[5].Text;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTen.Clear();
            txtSLTon.Clear();
            txtTGTon.Clear();
            txtCanhBao.Clear();

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
                this.Close(); // hoặc Application.Exit();
            }
        }

    }
}


