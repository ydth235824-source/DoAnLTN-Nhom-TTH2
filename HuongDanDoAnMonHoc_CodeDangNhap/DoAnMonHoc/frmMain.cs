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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQLK_Click(object sender, EventArgs e)
        {
            frmKho f = new frmKho();
            f.FormClosed += (s, args) => this.Show();  // khi form mới đóng → hiện lại form main
            f.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?",
                                      "Xác nhận",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void menuQLK_Click(object sender, EventArgs e)
        {
            this.Hide();                    // Ẩn form hiện tại
            frmKho frm = new frmKho();
            frm.ShowDialog();
            this.Show();
        }

        private void btnQLDT_Click(object sender, EventArgs e)
        {
            frmDoanhThu f = new frmDoanhThu();
            f.FormClosed += (s, args) => this.Show();  // khi form mới đóng → hiện lại form main
            f.Show();
            this.Hide();
        }

        private void menuQLDT_Click(object sender, EventArgs e)
        {
            this.Hide();                    // Ẩn form hiện tại
            frmDoanhThu frm = new frmDoanhThu();
            frm.ShowDialog();
            this.Show();
        }

        private void MenuQLHD_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.FormClosed += (s, args) => this.Show();  // khi form mới đóng → hiện lại form main
            f.Show();
            this.Hide();
        }

        private void btnQLNH_Click(object sender, EventArgs e)
        {
            frmNhap f = new frmNhap();
            f.FormClosed += (s, args) => this.Show();  // khi form mới đóng → hiện lại form main
            f.Show();
            this.Hide();
        }

        private void MenuQLNH_Click(object sender, EventArgs e)
        {
            frmNhap f = new frmNhap();
            f.FormClosed += (s, args) => this.Show();  // khi form mới đóng → hiện lại form main
            f.Show();
            this.Hide();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.FormClosed += (s, args) => this.Show();  // khi form mới đóng → hiện lại form main
            f.Show();
            this.Hide();
        }

        private void menuQLSP_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.FormClosed += (s, args) => this.Show();  // khi form mới đóng → hiện lại form main
            f.Show();
            this.Hide();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.FormClosed += (s, args) => this.Show();  // khi form mới đóng → hiện lại form main
            f.Show();
            this.Hide();
        }

        private void menuQLKH_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.FormClosed += (s, args) => this.Show();  // khi form mới đóng → hiện lại form main
            f.Show();
            this.Hide();
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.FormClosed += (s, args) => this.Show();  // khi form mới đóng → hiện lại form main
            f.Show();
            this.Hide();
        }

    }
}
