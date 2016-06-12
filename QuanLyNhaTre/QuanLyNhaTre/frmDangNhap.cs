using BUS;
using DTO;
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
    public partial class frmDangNhap : Form
    {
        DangNhap_DTO ObjDangnhap = new DangNhap_DTO();
        
        //Cái này là ủy quyền dùng để phân quyền người dùng
        public delegate void RunMAIN(int Quyen);
        public RunMAIN Run_MAIN;

        public static string taiKhoan;
        public static string matKhau;
        public static string maQuyen;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ObjDangnhap.TaiKhoan = txtTaiKhoan.Text;
            ObjDangnhap.MatKhau = txtMatKhau.Text;

            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Không được bỏ trống các trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtTaiKhoan.Text == "")
                    txtTaiKhoan.Focus();
                else txtMatKhau.Focus();
            }
            else
            {
                if (DangNhap_BUS.KiemTraTaiKhoan(ObjDangnhap) == true)
                {

                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";

                    taiKhoan = ObjDangnhap.TaiKhoan;
                    matKhau = ObjDangnhap.MatKhau;
                    maQuyen = DangNhap_BUS.MaQuyen(ObjDangnhap); // Lấy mã quyền của người dùng

                    MessageBox.Show("Đăng nhập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Run_MAIN(int.Parse(maQuyen)); // chạy hàm hiển thị tương ứng với mã quyền đó
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Focus();
                }
            }
        }
    }
}
