using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSannn.DAL
{
    public class DAL_DangNhap
    {
        KhachSanEntities db;
        public DAL_DangNhap()
        {
            db = new KhachSanEntities();
        }
        public bool kiemTraDN(String tk, String mk)
        {
            bool kq = false;
            NhanVien t = db.NhanViens.FirstOrDefault(s => s.Gmail == tk && s.MatKhau == mk);
            if (t != null)
                kq = true;
            return kq;
        }
        public bool kiemTraTKTonTai(String tk)
        {
            bool kq = false;
            NhanVien nv = db.NhanViens.FirstOrDefault(s => s.Gmail == tk);
            if (nv != null)
                kq = true;
            return kq;
        }
        public void ThemTK(NhanVien tk)
        {
            db.NhanViens.Add(tk);
            db.SaveChanges();
        }
        public bool KiemTraDinhDangMatKhau(string mk)
        {
            if (mk.Length >= 7)
            {
                return true;
            }
            return false;
        }
    }
}
