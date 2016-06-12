using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhap_BUS
    {
        public static bool KiemTraTaiKhoan(DangNhap_DTO dn)
        {
            return DangNhap_DAO.KiemTraTaiKhoan(dn);
        }
        public static string MaQuyen(DangNhap_DTO dn)
        {
            return DangNhap_DAO.MaQuyen(dn);
        }
    }
}
