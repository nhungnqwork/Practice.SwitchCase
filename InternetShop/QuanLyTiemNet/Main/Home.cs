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

namespace QuanLyTiemNet
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        string Tdn = Login.TenNickName;
        public static string leVel = SignUp.rankLbl;
        private void GetBalance()
        {
            sqlConnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where FullName='" + Tdn + "' ", sqlConnection);
            DataTable data = new DataTable();
            sda.Fill(data);
            sqlConnection.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            TenDangNhaplbl.Text = $"Xin chào, bạn {Login.TenNickName}";
            GetBalance();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Gift gf = new Gift();
            gf.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDeposit de = new AdminDeposit();
            de.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Balance bl = new Balance();
            bl.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fastcash fa = new fastcash();
            fa.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ministatement ministatement  = new Ministatement();
            ministatement.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormReport fr = new FormReport();
            fr.Show();
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminDeposit lc = new AdminDeposit();
            lc.Show();
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạo hóa đơn trên hệ thống\n\nChúng tôi sẽ gửi SERI + CODE đến bạn trong vòng 2-5p");
            OrderMember om = new OrderMember();
            om.Show();
            Close();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();   
            mn.Show();
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Home2 h = new Home2();
            h.Show();
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PhongMay pm = new PhongMay();
            pm.Show(); Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Admin_PhongMay ad_pm =  new Admin_PhongMay();   
            ad_pm.Show(); Close();  
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DatVeXemPhim dv = new DatVeXemPhim();
            dv.Show(); Close(); 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            COMBO_FASTFOOD cf = new COMBO_FASTFOOD();   
            cf.Show(); Close(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportUs ru = new ReportUs();
            ru.Show(); Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Menu_Film mf = new Menu_Film();
            mf.Show(); Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Menu_Film mf = new Menu_Film();
            mf.Show(); Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }
    }
}
