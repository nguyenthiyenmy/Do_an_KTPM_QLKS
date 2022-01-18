using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhachSannn.DAL;

namespace QLKhachSannn.BLL
{
    public class BLL_Phong
    {
        DAL_Phong dal;
        public BLL_Phong()
        {
            dal = new DAL_Phong();
        }
        public void hienThiDSSP(DataGridView dgv)
        {
            dgv.DataSource = dal.hienThiDSSP();
        }
        public List<Phong> TimMaPhong(String str)
        {
            return dal.timMaPhong(str);
        }
        public List<Phong> TimLoaiPhong(String str)
        {
            return dal.timLoaiPhong(str);
        }
        public List<Phong> TimTinhTrangPhong(String str)
        {
            return dal.timTinhTrangPhong(str);
        }
        public List<Phong> TimGiaPhong(string str)
        {
            return dal.timGiaPhong(str);
        }
    }
}
