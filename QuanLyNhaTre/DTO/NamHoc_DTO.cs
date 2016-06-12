using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NamHoc_DTO
    {
        String namHoc;
        String tenNamHoc;
        String ngayKG;
        String ngayKT;

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

        public string TenNamHoc
        {
            get
            {
                return tenNamHoc;
            }

            set
            {
                tenNamHoc = value;
            }
        }

        public string NgayKG
        {
            get
            {
                return ngayKG;
            }

            set
            {
                ngayKG = value;
            }
        }

        public string NgayKT
        {
            get
            {
                return ngayKT;
            }

            set
            {
                ngayKT = value;
            }
        }
    }
}
