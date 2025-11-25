using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMonHoc
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTen.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMain mainForm = new frmMain();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            txtTen.Clear();
            txtMatKhau.Clear();
            txtTen.Focus();
        }
    }
 }

