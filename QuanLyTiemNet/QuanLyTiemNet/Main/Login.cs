using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemNet
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string TenNickName;
        public static string TenDangNhap;
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "select count(*) from AccountTbl where username='"+TdnAccNumtb.Text+"' and password='"+MkhauTb.Text+"'"; 
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlAdapter.Fill(data);
            if (data.Rows[0][0].ToString() == "1")
            {
                TenNickName = nicknameTb.Text;
                TenDangNhap = TdnAccNumtb.Text;

                DialogResult h = MessageBox.Show("Chào mừng bạn đến với IMD!\n\nBạn có phải người mới không?\n\nHãy đến nhận phần quà cho người mới nhé!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (h == DialogResult.OK)
                {
                    Gift g = new Gift();
                    g.Show();
                    this.Close();
                }
                else
                {
                    Home hm = new Home();
                    hm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập thiếu thông tin hoặc chưa đăng ký thành viên");
            }
            sqlConnection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "select count(*) from AdminTbl where username='" + TdnAccNumtb.Text + "' and password='" + MkhauTb.Text + "'";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlAdapter.Fill(data);
            if (data.Rows[0][0].ToString() == "1")
            {
                TenNickName = nicknameTb.Text;
                TenDangNhap = TdnAccNumtb.Text;
                Home h = new Home();
                h.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn không phải là quản trị viên");
            }
            sqlConnection.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TdnAccNumtb.Text = SignUp.tKMT;
        }
    }
}
