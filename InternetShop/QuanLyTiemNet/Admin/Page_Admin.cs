using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemNet
{
    public partial class Page_Admin : Form
    {
        public Page_Admin()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Admin_PhongMay ad = new Admin_PhongMay();   
            ad.Show();
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ListCard lc = new ListCard();
            lc.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Deposit dp = new Deposit();
            dp.Show();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CheckBill cb = new CheckBill();
            cb.Show(); Close();
        }
    }
}
