using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLy_ToiPhamTheKy
{
    public partial class InfoDetail : Form
    {
        public InfoDetail()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-77LQJ4S;Initial Catalog=MafiaDb;Integrated Security=True");
        Modify modify= new Modify();
        private void populate()
        {
            sqlConnection.Open();
            string query = "select * from BaoTonThongTinPNTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            infodetailDTGV.DataSource = data;
            sqlConnection.Close();
        }

        private void InfoDetail_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = NameTb.Text;
            if (name == "")
            {
                InfoDetail_Load(sender, e);
            }
            else if (NameTb.Text == "1947_Bugs")
            {
                PictureBox pb2 = new PictureBox();
                pb2.Image = Image.FromFile("C:/Users/huynh/Downloads/s-l400.jpg");
                pb2.Location = new Point(500, 70);
                pb2.Size = new Size(700, 300);
                Controls.Add(pb2);
            }
            else if (NameTb.Text == "19091213_NC")
            {
                PictureBox pb2 = new PictureBox();
                pb2.Image = Image.FromFile("C:/Users/huynh/Downloads/n3.jpg");
                pb2.Location = new Point(450, 65);
                pb2.Size = new Size(400, 335);
                Controls.Add(pb2);
            }
            else if (NameTb.Text == "1206_MB")
            {
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/m1.jpg");
                pb1.Location = new Point(460, 15);
                pb1.Size = new Size(450, 400);
                Controls.Add(pb1);
            }
            else if (NameTb.Text == "1928_LL")
            {
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/l1.jpg");
                pb1.Location = new Point(460, 0);
                pb1.Size = new Size(500, 500);
                Controls.Add(pb1);
            }
            else if (NameTb.Text == "2023_MJD")
            {
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/d1.jpg");
                pb1.Location = new Point(460, 120);
                pb1.Size = new Size(500, 500);
                Controls.Add(pb1);
            }
            else if (NameTb.Text == "2023_MJD")
            {
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/d1.jpg");
                pb1.Location = new Point(460, 120);
                pb1.Size = new Size(500, 500);
                Controls.Add(pb1);
            }
            else if (NameTb.Text == "2017_CM")
            {
                PictureBox pb2 = new PictureBox();
                pb2.Image = Image.FromFile("C:/Users/huynh/Downloads/c2.jpg");
                pb2.Location = new Point(500, 65);
                pb2.Size = new Size(500, 550);
                Controls.Add(pb2);
            }
            else if (NameTb.Text == "2209_JM")
            {
                PictureBox pb3 = new PictureBox();
                pb3.Image = Image.FromFile("C:/Users/huynh/Downloads/j2.png");
                pb3.Location = new Point(470, 75);
                pb3.Size = new Size(500, 500); // width, height
                Controls.Add(pb3);
            }
            else if (NameTb.Text == "0211_TN")
            {
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/huynh/Downloads/t1.jpg");
                pb1.Location = new Point(500, 75);
                pb1.Size = new Size(330, 400); // width, height
                Controls.Add(pb1);
            }
        }

        private void infodetailDTGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NguyennhanTb.Text = infodetailDTGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string name = FullNameTb.Text;
            if (name == "")
            {
                InfoDetail_Load(sender, e);
            }
            else
            {
                string query = "Select * from BaoTonThongTinPNTbl Where Hovaten like '%" + name + "%'";
                infodetailDTGV.DataSource = modify.Table(query);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            InfoDetail id = new InfoDetail();
            id.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Image_Prison ip = new Image_Prison();
            ip.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Sentenced S = new Sentenced();
            S.Show();
            Close();
        }
    }
}
