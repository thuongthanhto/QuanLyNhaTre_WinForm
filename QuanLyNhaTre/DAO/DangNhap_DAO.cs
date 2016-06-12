using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DangNhap_DAO
    {
        public static bool KiemTraTaiKhoan(DangNhap_DTO dn)
        {
            string sql = String.Format("select * from NGUOIDUNG where TaiKhoan='{0}' and MatKhau='{1}'",dn.TaiKhoan,dn.MatKhau);
            if (DataAccess.ExcuteReader_bool(sql) == true)
                return true;
            else
                return false;
        }
        public static string MaQuyen(DangNhap_DTO dn)
        {
            string sql = string.Format("select MaQuyen from NGUOIDUNG where TaiKhoan='{0}'", dn.TaiKhoan);
            return DataAccess.ExecuteScalar_string(sql);
        }
    }
}
