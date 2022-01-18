using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhachSannn.BLL;

namespace QLKhachSannn
{
    public partial class TraCuu : Form
    {
        BLL_Phong dal;
        public TraCuu()
        {
            InitializeComponent();
            dal = new BLL_Phong();
        }
        private int TimKiemMaPhong()
        {
            string key = txtTimKiem.Text;
            if (dal.TimMaPhong(key) != null)
            {
                gridDsPhong.DataSource = dal.TimMaPhong(key);
                return 1;
            }
            else
                return 0;

        }
        private int TimKiemLoaiPhong()
        {
            string key = txtTimKiem.Text;
            if (dal.TimLoaiPhong(key) != null)
            {
                gridDsPhong.DataSource = dal.TimLoaiPhong(key);
                return 1;
            }
            else
                return 0;
        }
        private int TimKiemTinhTrangPhong()
        {
            string key = txtTimKiem.Text;
            if (dal.TimTinhTrangPhong(key) != null)
            {
                gridDsPhong.DataSource = dal.TimTinhTrangPhong(key);
                return 1;
            }
            else
                return 0;
        }
        private int TimKiemGiaPhong()
        {
            string key =txtTimKiem.Text;
            if (dal.TimGiaPhong(key) != null)
            {
                gridDsPhong.DataSource = dal.TimGiaPhong(key);
                return 1;
            }
            else
                return 0;
        }

        private void btTimKiem_Click_1(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() != "")
            {
                if (rdMa.Checked)
                {
                    TimKiemMaPhong();
                    if (TimKiemMaPhong() == 0)
                    {
                        MessageBox.Show("Không tìm thấy");
                    }
                }
                else
                if (rdLoai.Checked)
                {
                    TimKiemLoaiPhong();
                    if (TimKiemLoaiPhong() == 0)
                    {
                        MessageBox.Show("Không tìm thấy");
                    }
                }
                else
                if (rdTinhTrang.Checked)
                {
                    TimKiemTinhTrangPhong();
                    if (TimKiemTinhTrangPhong() == 0)
                    {
                        MessageBox.Show("Không tìm thấy");
                    }
                }
                else
                {
                    TimKiemGiaPhong();
                    if (TimKiemGiaPhong() == 0)
                    {
                        MessageBox.Show("Không tìm thấy");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa  nhập từ tìm kiếm.");
                txtTimKiem.Focus();
            }

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridDsPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TraCuu_Load(object sender, EventArgs e)
        {
            dal.hienThiDSSP(gridDsPhong);
        }
    }
}
