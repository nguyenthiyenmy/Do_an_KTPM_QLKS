using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhachSannn.DAL;

namespace QLKhachSannn.BLL
{
    public class BLL_DatPhong
    {
        DAL_DatPhong dal = new DAL_DatPhong();
        public void hienThiDSDP(DataGridView dgv)
        {
            dgv.DataSource = dal.hienThiDSDP();
        }
        public bool themDatPhong(DatPhong sp)
        {
            //using (var trac = new TransactionScope())
            {
                try
                {
                    dal.DatPhong(sp);
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }
    }
}
