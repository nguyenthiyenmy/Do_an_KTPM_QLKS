using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSannn.DAL
{
    public class DAL_DichVu
    {
        KhachSanEntities db = new KhachSanEntities();
        public void themDV(DichVu dv)
        {
            db.DichVus.Add(dv);
            db.SaveChanges();
        }
        public void xoaDV(string maDV)
        {
            DichVu l = db.DichVus.Find(maDV);
            db.DichVus.Remove(l);
            db.SaveChanges();
        }
        public void suaDV(string maDV, DichVu dv)
        {
            DichVu l = db.DichVus.Where(w => w.MaDV == maDV).Select(s => s).FirstOrDefault();
            l.TenDV = dv.TenDV;
            l.Gia = dv.Gia;
            db.SaveChanges();
        }
        public dynamic hienThiDSDV()
        {
            var sp = db.DichVus.Select(s => new {
                s.MaDV,
                s.TenDV,
                s.Gia
            }).ToList();
            return sp;
        }
        public List<DichVu> SearchTenDV(string key)
        {
            List<DichVu> result = new List<DichVu>();
            result = db.DichVus.Where(p => p.TenDV == key).ToList();
            return result;
        }
    }
}
