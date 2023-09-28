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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startLogin = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startLogin += 5;
            progressBar1.Value = startLogin;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
