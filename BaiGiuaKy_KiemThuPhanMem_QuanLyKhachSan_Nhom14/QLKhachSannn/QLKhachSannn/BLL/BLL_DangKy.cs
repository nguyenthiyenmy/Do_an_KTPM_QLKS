using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKhachSannn.DAL;

namespace QLKhachSannn.BLL
{
    public class BLL_DangKy
    {
        DAL_DangKy dTaiKhoan = new DAL_DangKy();
        public bool kiemTraDN(String tk, String mk)
        {
            return dTaiKhoan.kiemTraDN(tk, mk);
        }
        public bool ThemTK(NhanVien tk)
        {
            try
            {
                dTaiKhoan.ThemTK(tk);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool KiemTraDinhDangMatKhau(String mk)
        {
            return dTaiKhoan.KiemTraDinhDangMatKhau(mk);
        }
        public bool kiemTraTKTonTai(String tk)
        {
            return dTaiKhoan.kiemTraTKTonTai(tk);
        }
        public List<NhanVien> LoadTK()
        {
            return dTaiKhoan.LoadTK();
        }
    }
}
