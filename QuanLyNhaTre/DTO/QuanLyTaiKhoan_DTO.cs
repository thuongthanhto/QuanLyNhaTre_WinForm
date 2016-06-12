using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLyTaiKhoan_DTO
    {
        String taiKhoan;
        String matKhau;
        int maQuyen;

        public string TaiKhoan
        {
            get
            {
                return taiKhoan;
            }

            set
            {
                taiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public int MaQuyen
        {
            get
            {
                return maQuyen;
            }

            set
            {
                maQuyen = value;
            }
        }
    }
}
