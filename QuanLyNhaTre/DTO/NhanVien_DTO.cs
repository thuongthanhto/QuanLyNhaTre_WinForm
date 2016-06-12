using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NhanVien_DTO
    {
        String maNV;
        String hoTenNV;
        String ngaySinh;
        String diaChi;
        String gioiTinh;
        String trinhDo;
        String totNghiepTruong;
        String chucVu;

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }

        public string HoTenNV
        {
            get
            {
                return hoTenNV;
            }

            set
            {
                hoTenNV = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string TrinhDo
        {
            get
            {
                return trinhDo;
            }

            set
            {
                trinhDo = value;
            }
        }

        public string TotNghiepTruong
        {
            get
            {
                return totNghiepTruong;
            }

            set
            {
                totNghiepTruong = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return chucVu;
            }

            set
            {
                chucVu = value;
            }
        }
    }
}
