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
    public partial class Dat_Phong : Form
    {
        BLL_DatPhong bDatPhong;
        bool flag = false;
        public Dat_Phong()
        {
            InitializeComponent();
            bDatPhong = new BLL_DatPhong();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaDP.Text == "" || txtMaKH.Text == "" || txtNgayDat.Text == "" ||
                txtNgayNhan.Text == "" || txtNgayTra.Text == "" || cbMaNV.Text == "" ||
                cbMaPhong.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            else
            {
                DatPhong dp = new DatPhong();
                dp.MaDP = txtMaDP.Text;
                dp.MaNV = cbMaNV.Text;
                dp.MaPhong = cbMaPhong.Text;
                dp.MaKH = txtMaKH.Text;
                dp.NgayDat = txtNgayDat.Text;
                dp.NgayNhan = txtNgayNhan.Text;
                dp.NgayTra = txtNgayTra.Text;
                if (bDatPhong.themDatPhong(dp))
                {
                    MessageBox.Show("Đặt phòng thành công");
                    bDatPhong.hienThiDSDP(gridDatPhong);
                    flag = false;
                    txtMaDP.Text = "";
                    txtMaKH.Text = "";
                    cbMaNV.Text = "";
                    cbMaPhong.Text = "";
                    txtNgayDat.Text = "";
                    txtNgayNhan.Text = "";
                    txtNgayTra.Text = "";

                    bDatPhong.hienThiDSDP(gridDatPhong);
                }
                else
                    MessageBox.Show("Đặt phòng thất bại ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Dat_Phong_Load(object sender, EventArgs e)
        {

        }
    }
}
