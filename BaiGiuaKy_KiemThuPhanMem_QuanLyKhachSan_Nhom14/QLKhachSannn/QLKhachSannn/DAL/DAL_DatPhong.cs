using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSannn.DAL
{
    public class DAL_DatPhong
    {
        KhachSanEntities db = new KhachSanEntities();
        public void DatPhong(DatPhong dp)
        {
            db.DatPhongs.Add(dp);
            db.SaveChanges();
        }

        public dynamic hienThiDSDP()
        {
            var sp = db.DatPhongs.Select(s => new {
                s.MaDP,
                s.MaKH,
                s.MaNV,
                s.MaPhong,
                s.NgayDat,
                s.NgayNhan,
                s.NgayTra,
            }).ToList();
            return sp;
        }
    }
}
