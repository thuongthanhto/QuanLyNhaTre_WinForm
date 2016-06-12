using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Khoi_NamHoc_DTO
    {
        String namHoc;
        String khoiHoc;

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

        public string KhoiHoc
        {
            get
            {
                return khoiHoc;
            }

            set
            {
                khoiHoc = value;
            }
        }
    }
}
