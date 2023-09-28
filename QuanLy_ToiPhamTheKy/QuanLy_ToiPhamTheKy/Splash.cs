using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_ToiPhamTheKy
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            MyProgress.Value = startpoint;
            percent.Text = startpoint+ "%";
            if (MyProgress.Value == 100)
            {
                timer1.Stop();
                Sentenced s =new Sentenced();
                s.Show();
                Hide();
            }
        }

        private void MyProgress_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
