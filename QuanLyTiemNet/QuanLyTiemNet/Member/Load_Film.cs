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
    public partial class Load_Film : Form
    {
        public Load_Film()
        {
            InitializeComponent();
        }
        int loadFilm = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadFilm += 2;
            progressBar1.Value = loadFilm;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Hoàn tất việc thanh toán");
                Bill_Phim cf = new Bill_Phim();
                cf.Show();
                Close();
            }
        }

        private void Load_Film_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
