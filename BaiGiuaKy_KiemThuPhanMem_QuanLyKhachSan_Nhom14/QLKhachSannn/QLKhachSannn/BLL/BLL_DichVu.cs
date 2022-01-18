using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhachSannn.DAL;

namespace QLKhachSannn.BLL
{
    public class BLL_DichVu
    {
        DAL_DichVu dDichVu = new DAL_DichVu();
        public void hienThiDSDV(DataGridView dgv)
        {
            dgv.DataSource = dDichVu.hienThiDSDV();
        }
        public List<DichVu> hienthiDV()
        {
            return dDichVu.hienThiDSDV().ToList();
        }
        public bool themDV(DichVu dv)
        {
            //using (var trac = new TransactionScope())
            {
                try
                {
                    dDichVu.themDV(dv);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool suaDV(string maDV, DichVu dv)
        {
            try
            {
                dDichVu.suaDV(maDV, dv);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool xoaDV(string maDV)
        {
            try
            {
                dDichVu.xoaDV(maDV);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<DichVu> SearchTenDV(string key)
        {
            return dDichVu.SearchTenDV(key);
        }
    }

}
