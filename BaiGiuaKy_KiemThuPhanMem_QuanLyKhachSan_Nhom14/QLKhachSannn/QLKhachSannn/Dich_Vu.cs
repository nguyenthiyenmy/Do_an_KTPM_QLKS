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
    public partial class Dich_Vu : Form
    {
        bool flag = false;
        BLL_DichVu bDichVu = new BLL_DichVu();
        public Dich_Vu()
        {
            InitializeComponent();
        }
        private void Dich_Vu_Load(object sender, EventArgs e)
        {
            bDichVu.hienThiDSDV(GridDV);
        }

        private void GridDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < GridDV.Rows.Count)
            {
                txtTenDV.Text = GridDV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGiaDV.Text = GridDV.Rows[e.RowIndex].Cells[2].Value.ToString();
                flag = true;
                txtMaDV.Text = GridDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text == "" || txtGiaDV.Text == "" || txtMaDV.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            else
            {
                {
                    DichVu dv = new DichVu();
                    dv.TenDV = txtTenDV.Text;
                    dv.Gia = txtGiaDV.Text;
                    dv.MaDV = txtMaDV.Text;
                    if (bDichVu.themDV(dv))
                    {
                        MessageBox.Show("Thêm dịch vụ thành công");
                        bDichVu.hienThiDSDV(GridDV);
                        flag = false;
                        txtMaDV.Text = "";
                        txtGiaDV.Text = "";
                        txtTenDV.Text = "";
                        bDichVu.hienThiDSDV(GridDV);
                    }
                    
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text == "" || txtGiaDV.Text == "" || txtMaDV.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            else
            {
                {
                    DichVu dv = new DichVu();
                    dv.TenDV = txtTenDV.Text;
                    dv.Gia = txtGiaDV.Text;
                    dv.MaDV = txtMaDV.Text;
                    if (bDichVu.suaDV(txtMaDV.Text, dv))
                    {
                        MessageBox.Show("Cập nhật dịch vụ thành công");
                        bDichVu.hienThiDSDV(GridDV);
                        flag = false;
                        txtMaDV.Text = "";
                        txtGiaDV.Text = "";
                        txtTenDV.Text = "";
                        bDichVu.hienThiDSDV(GridDV);
                    }
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                MessageBox.Show("Vui lòng chọn loại dịch vụ cần xóa");
            }
            else
            {
                if (bDichVu.xoaDV(txtMaDV.Text))
                {
                    MessageBox.Show("Xóa dịch vụ thành công");
                    bDichVu.hienThiDSDV(GridDV);
                    flag = false;
                    txtMaDV.Text = "";
                    txtGiaDV.Text = "";
                    txtTenDV.Text = "";
                    bDichVu.hienThiDSDV(GridDV);
                }
                else
                {
                    MessageBox.Show("Xóa dịch vụ thất bại.");
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
