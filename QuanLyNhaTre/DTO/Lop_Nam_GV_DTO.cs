using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Lop_Nam_GV_DTO
    {
        String maGV;
        String maLop;
        String namHoc;
        String tenKhoi;

        public string MaGV
        {
            get
            {
                return maGV;
            }

            set
            {
                maGV = value;
            }
        }

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
