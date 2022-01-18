using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKhachSannn.DAL;

namespace QLKhachSannn.BLL
{
    public class BLL_DangNhap
    {
        DAL_DangNhap dal = new DAL_DangNhap();

        public bool kiemTraDN(String tk, String mk)
        {
            return dal.kiemTraDN(tk, mk);
        }
        public bool kiemTraTKTonTai(String tk)
        {
            return dal.kiemTraTKTonTai(tk);
        }
        public bool ThemTK(NhanVien tk)
        {
            try
            {
                dal.ThemTK(tk);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool KiemTraDinhDangMatKhau(String mk)
        {
            return dal.KiemTraDinhDangMatKhau(mk);
        }
    }
}
