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
    public partial class Image_Prison : Form
    {
        public Image_Prison()
        {
            InitializeComponent();
        }
        private void Image_Prison_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (name == "")
            {
                Image_Prison_Load(sender,e);
            }
            else if(textBox1.Text == "1947_Bugs")
            {
                comboBox1.SelectedIndex = 0;
                PictureBox pb1 = new PictureBox();
                PictureBox pb2 = new PictureBox();
                PictureBox pb3 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/b161c0f4760fa351fa1e.jpg");
                pb2.Image = Image.FromFile("C:/Users/huynh/Downloads/s-l400.jpg");
                pb3.Image = Image.FromFile("C:/Users/huynh/Downloads/image-240x298.jpg");
                pb1.Location = new Point(0, 70);
                pb2.Location = new Point(650, 70);
                pb3.Location = new Point(700, 400);
                pb1.Size = new Size(700, 700);
                pb2.Size = new Size(700, 300);
                pb3.Size = new Size(1000, 1000);
                Controls.Add(pb1);
                Controls.Add(pb2);
                Controls.Add(pb3);
            }
            else if(textBox1.Text == "19091213_NC" || textBox1.Text == "Nikolas" || textBox1.Text == "nikolas" || textBox1.Text == "Nikolas Cruz"|| textBox1.Text == "nikolas cruz")
            {
                comboBox1.SelectedIndex = 1;
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/n1.png");
                pb1.Location = new Point(0, 80);
                pb1.Size = new Size(450, 510);
                Controls.Add(pb1);
                PictureBox pb2 = new PictureBox();
                pb2.Image = Image.FromFile("C:/Users/huynh/Downloads/n3.jpg");
                pb2.Location = new Point(460, 80);
                pb2.Size = new Size(500, 510);
                Controls.Add(pb2);
            }
            else if (textBox1.Text == "1206_MB" || textBox1.Text == "Martin" || textBox1.Text == "martin" || textBox1.Text == "Martin Bryant" || textBox1.Text == "martin bryant")
            {
                comboBox1.SelectedIndex = 2;
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/m1.jpg");
                pb1.Location = new Point(0, 65);
                pb1.Size = new Size(450, 620);
                Controls.Add(pb1);
                PictureBox pb2 = new PictureBox();
                pb2.Image = Image.FromFile("C:/Users/huynh/Downloads/m2.jpg");
                pb2.Location = new Point(460, 65);
                pb2.Size = new Size(500, 620);
                Controls.Add(pb2);
            }
            else if (textBox1.Text == "1928_LL" || textBox1.Text == "Lucky Luciano" || textBox1.Text == "lucky luciano" || textBox1.Text == "lucky" || textBox1.Text == "Lucky")
            {
                comboBox1.SelectedIndex = 3;
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/l1.jpg");
                pb1.Location = new Point(0, 65);
                pb1.Size = new Size(1300, 620);
                Controls.Add(pb1);
            }
            else if (textBox1.Text == "2023_MJD")
            {
                comboBox1.SelectedIndex = 4;
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/d1.jpg");
                pb1.Location = new Point(0, 70);
                pb1.Size = new Size(300, 250);
                Controls.Add(pb1);
                PictureBox pb2 = new PictureBox();
                pb2.Image = Image.FromFile("C:/Users/huynh/Downloads/d2.jpg");
                pb2.Location = new Point(350, 70);
                pb2.Size = new Size(300, 250);
                Controls.Add(pb2);
                PictureBox pb3 = new PictureBox();
                pb3.Image = Image.FromFile("C:/Users/huynh/Downloads/d3.jpg");
                pb3.Location = new Point(0, 350);
                pb3.Size = new Size(300, 300);
                Controls.Add(pb3);
                PictureBox pb4 = new PictureBox();
                pb4.Image = Image.FromFile("C:/Users/huynh/Downloads/d4.jpg");
                pb4.Location = new Point(350, 350);
                pb4.Size = new Size(300, 300);
                Controls.Add(pb4);
            }
            else if (textBox1.Text == "2017_CM")
            {
                comboBox1.SelectedIndex = 5;
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/c1.jpg");
                pb1.Location = new Point(0, 65);
                pb1.Size = new Size(500, 450);
                Controls.Add(pb1);
                PictureBox pb2 = new PictureBox();
                pb2.Image = Image.FromFile("C:/Users/huynh/Downloads/c2.jpg");
                pb2.Location = new Point(500, 65);
                pb2.Size = new Size(500, 550);
                Controls.Add(pb2);
                PictureBox pb3 = new PictureBox();
                pb3.Image = Image.FromFile("C:/Users/huynh/Downloads/c3.jpg");
                pb3.Location = new Point(0, 500);
                pb3.Size = new Size(500, 550);
                Controls.Add(pb3);
            }
            else if (textBox1.Text == "2209_JM")
            {
                comboBox1.SelectedIndex = 6;
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/j1.jpg");
                pb1.Location = new Point(0, 75);
                pb1.Size = new Size(330, 500); // width, height
                Controls.Add(pb1);
                PictureBox pb2 = new PictureBox();
                pb2.Image = Image.FromFile("C:/Users/huynh/Downloads/j2.png");
                pb2.Location = new Point(170, 75);
                pb2.Size = new Size(400, 500); // width, height
                Controls.Add(pb2);
                PictureBox pb3 = new PictureBox();
                pb3.Image = Image.FromFile("C:/Users/huynh/Downloads/j3.jpg");
                pb3.Location = new Point(570, 75);
                pb3.Size = new Size(400, 500); // width, height
                Controls.Add(pb3);
            }
            else if (textBox1.Text == "0211_TN")
            {
                comboBox1.SelectedIndex = 7;
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/t1.jpg");
                pb1.Location = new Point(0, 75);
                pb1.Size = new Size(330, 400); // width, height
                Controls.Add(pb1);
                PictureBox pb2 = new PictureBox();
                pb2.Image = Image.FromFile("C:/Users/huynh/Downloads/t2.jpg");
                pb2.Location = new Point(330, 75);
                pb2.Size = new Size(800, 700); // width, height
                Controls.Add(pb2);
                PictureBox pb3 = new PictureBox();
                pb3.Image = Image.FromFile("C:/Users/huynh/Downloads/t3.jpg");
                pb3.Location = new Point(0, 475);
                pb3.Size = new Size(400, 500); // width, height
                Controls.Add(pb3);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Image_Prison ip =  new Image_Prison();
            ip.Show();
        }

        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                ttctTb.Text = "Bugsy Siegel hay Benjamin Siegel là một tay xã hội đen người Mỹ gốc Do Thái, người có liên quan đến tổ chức tội phạm Mafia ở Mỹ.\n Cùng với vẻ ngoài điển trai, Siegel được biết tới là một trong những tay anh chị khét tiếng nhất cùng thời. Ngày sinh: 28 tháng 2, 1906";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                ttctTb.Text = "Nikolas Jacob Cruz là một kẻ sát nhân hàng loạt người Mỹ đã gây ra vụ xả súng ở trường trung học Parkland, nơi hắn bắn chết 17 người và làm bị thương 17 người khác vào ngày 14 tháng 2 năm 2018.\n Ngày sinh: 24 tháng 9, 1998";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                ttctTb.Text = "Martin John Bryant là một kẻ giết người hàng loạt người Úc đã sát hại 35 người và làm bị thương 23 người khác trong một vụ xả súng hàng loạt trong vụ thảm sát Port Arthur, một trong những vụ xả súng đẫm máu nhất thế giới, ở Port Arthur, Tasmania. Ngày sinh: 7 tháng 5, 1967";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                ttctTb.Text = "Luciano là một ông trùm mafia người Mỹ gốc Ý. Ông ta còn là \"bố già\", kẻ cầm đầu nghiệp đoàn tội phạm quốc gia và là kẻ cầm đầu đường dây buôn ma túy xuyên quốc gia trong thời Chiến tranh thế giới thứ hai. Ngày sinh: 24 tháng 11, 1897";
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            InfoDetail ID = new InfoDetail();
            ID.Show();
        }
    }
}
