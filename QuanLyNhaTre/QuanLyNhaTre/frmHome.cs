using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre
{
    public partial class frmHome : Form
    {
        public static int dem = 0;
        int TogMove;
        int MValX;
        int MValY;
        public void HienThi(int q)
        {
            if (q == 1)
            {
                btnQLNhanVien.Enabled = true;
                btnPhanCong.Enabled = true;
                btnQLThucDon.Enabled = true;
                btnQLTre.Enabled = true;
                btnNHKL.Enabled = true;
                btnXepLop.Enabled = true;
                btnDangNhap.Enabled = false;
                btnDoiMatKhau.Enabled = true;
                btnDangXuat.Enabled = true;
                btnSetting.Enabled = true;
            }
            else
            {
                btnQLNhanVien.Enabled = false;
                btnPhanCong.Enabled = false;
                btnQLThucDon.Enabled = false;
                btnQLTre.Enabled = false;
                btnNHKL.Enabled = false;
                btnXepLop.Enabled = false;
                btnSetting.Enabled = false;
                btnDangXuat.Enabled = false;
                btnDoiMatKhau.Enabled = false;
                btnDangNhap.Enabled = true;               
            }
        }
        public frmHome()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.btnSetting, "Quản Lý Tài Khoản");
            toolTip.SetToolTip(this.btnDoiMatKhau, "Đổi Mật Khẩu");
            toolTip.SetToolTip(this.btnDangNhap, "Đăng Nhập");
            toolTip.SetToolTip(this.btnDangXuat, "Đăng Xuất");
            this.WindowState = FormWindowState.Maximized;           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMininize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            dem++;
            if (dem%2!=0)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlLeft.Width == 270)
            {
                pnlLeft.Width = 45;
                
            }
            else
            {
                pnlLeft.Width = 270;               
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            pnlLeft.Width = 45;

            HienThi(0); // Quyền là khách

            frmDangNhap dn = new frmDangNhap();
            dn.MdiParent = this;
            dn.Run_MAIN = new frmDangNhap.RunMAIN(HienThi);
            dn.ShowIcon = false;
            dn.Dock = DockStyle.Fill;
            dn.Show();
        }

        private void lbl_true(System.Windows.Forms.Button b)
        {
            btnQLNhanVien.BackColor = Color.Transparent;
            btnQLThucDon.BackColor = Color.Transparent;
            btnPhanCong.BackColor = Color.Transparent;
            btnNHKL.BackColor = Color.Transparent;
            btnQLTre.BackColor = Color.Transparent;
            btnXepLop.BackColor = Color.Transparent;
            b.BackColor = Color.FromArgb(19, 89, 149);
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            lbl_true(btnQLNhanVien);
            frmQLNV item = new frmQLNV();
            item.MdiParent = this;
            item.ShowIcon = false;
            item.Dock = DockStyle.Fill;
            item.Show();
        }

        private void btnQLTre_Click(object sender, EventArgs e)
        {
            lbl_true(btnQLTre);
            frmQLTre item = new frmQLTre();
            item.MdiParent = this;
            item.ShowIcon = false;
            item.Dock = DockStyle.Fill;
            item.Show();
        }

        private void btnNHKL_Click(object sender, EventArgs e)
        {
            lbl_true(btnNHKL);
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            lbl_true(btnPhanCong);
        }

        private void btnXepLop_Click(object sender, EventArgs e)
        {
            lbl_true(btnXepLop);
        }

        private void btnQLThucDon_Click(object sender, EventArgs e)
        {
            lbl_true(btnQLThucDon);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Program.frm_Quanlytaikhoan.MdiParent = this;
            Program.frm_Quanlytaikhoan.ShowIcon = false;
            Program.frm_Quanlytaikhoan.Dock = DockStyle.Fill;
            Program.frm_Quanlytaikhoan.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            HienThi(0); // Quyền là khách

            Program.frm_DangNhap.MdiParent = this;
            Program.frm_DangNhap.Run_MAIN = new frmDangNhap.RunMAIN(HienThi);
            Program.frm_DangNhap.ShowIcon = false;
            Program.frm_DangNhap.Dock = DockStyle.Fill;
            Program.frm_DangNhap.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            //Đóng tất cả các form đang chạy
            //Duyệt qua tất cả các form là form con của form đang chạy rồi đóng
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }

            HienThi(0);

            Program.frm_DangNhap.MdiParent = this;
            Program.frm_DangNhap.Run_MAIN = new frmDangNhap.RunMAIN(HienThi);
            Program.frm_DangNhap.ShowIcon = false;
            Program.frm_DangNhap.Dock = DockStyle.Fill;

            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            Program.frm_DangNhap.Show();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Program.frm_Doimatkhau.MdiParent = this;
            Program.frm_Doimatkhau.ShowIcon = false;
            Program.frm_Doimatkhau.Dock = DockStyle.Fill;
            Program.frm_Doimatkhau.Show();
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();
            Application.Exit();
        }
    }
}
