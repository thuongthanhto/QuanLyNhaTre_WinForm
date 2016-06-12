using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoiMatKhau_DTO
    {
        String taiKhoan;
        String matKhauCu;
        String matKhauMoi;
        String nhapLaiMatKhauMoi;

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

        public string MatKhauCu
        {
            get
            {
                return matKhauCu;
            }

            set
            {
                matKhauCu = value;
            }
        }

        public string MatKhauMoi
        {
            get
            {
                return matKhauMoi;
            }

            set
            {
                matKhauMoi = value;
            }
        }

        public string NhapLaiMatKhauMoi
        {
            get
            {
                return nhapLaiMatKhauMoi;
            }

            set
            {
                nhapLaiMatKhauMoi = value;
            }
        }
    }
}
