using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSannn
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void TraCuuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuu f = new TraCuu();
            f.Show();
        }

        private void DatPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dat_Phong f = new Dat_Phong();
            f.Show();
        }

        private void DichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dich_Vu f = new Dich_Vu();
            f.Show();
        }
    }
}
