using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HS_Lop_DTO
    {
        String maLop;
        String maHS;
        String namHoc;
        String tenKhoi;

        public string MaLop
        {
            get
            {
                return maLop;
            }

            set
            {
                maLop = value;
            }
        }

        public string MaHS
        {
            get
            {
                return maHS;
            }

            set
            {
                maHS = value;
            }
        }

        public string NamHoc
        {
            get
            {
                return namHoc;
            }

            set
            {
                namHoc = value;
            }
        }

        public string TenKhoi
        {
            get
            {
                return tenKhoi;
            }

            set
            {
                tenKhoi = value;
            }
        }
    }
}
