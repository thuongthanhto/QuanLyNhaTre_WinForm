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
        public frmHome()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.btnSetting, "Setting");
            toolTip.SetToolTip(this.btnHelp, "Help");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
