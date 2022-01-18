using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSannn.DAL
{

    public class DAL_Phong
    {
        KhachSanEntities db;
        public DAL_Phong()
        {
            db = new KhachSanEntities();
        }
        public List<Phong> timMaPhong(String str)
        {
            List<Phong> sp = new List<Phong>();
            sp = db.Phongs.Where(p => p.MaPhong == str).ToList();
            return sp;
        }
        public List<Phong> timLoaiPhong(String str)
        {
            List<Phong> sp = new List<Phong>();
            sp = db.Phongs.Where(p => p.LoaiPhong == str).ToList();
            return sp;
        }
        public List<Phong> timTinhTrangPhong(String str)
        {
            List<Phong> sp = new List<Phong>();
            sp = db.Phongs.Where(p => p.TinhTrang == str).ToList();
            return sp;
        }
        public List<Phong> timGiaPhong(string str)
        {
            List<Phong> sp = new List<Phong>();
            sp = db.Phongs.Where(p => p.Gia == str).ToList();
            return sp;
        }
        public dynamic hienThiDSSP()
        {
            var sp = db.Phongs.Select(s => new
            {
                s.MaPhong,
                s.LoaiPhong,
                s.TinhTrang,
                s.Gia
            }).ToList();
            return sp;
        }
    }
 }
