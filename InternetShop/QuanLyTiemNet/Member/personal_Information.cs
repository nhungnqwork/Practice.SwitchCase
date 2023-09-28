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
    public partial class personal_Information : Form
    {
        public personal_Information()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        string Tdn = Login.TenDangNhap;
        private void populate()
        {
            sqlConnection.Open();
            string query = "select UserName,FullName,Dob,Level from AccountTbl where UserName='" + Tdn+"'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            data.Fill(tb);
            infoDTGV1.DataSource = tb;
            sqlConnection.Close();
        }

        private void personal_Information_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Level 0 => Thành viên: tiêu dùng < 150.000d\nLevel 1 => Đại lý cấp 1: tiêu dùng < 350.000d \nLevel 2 => Đại lý cấp 2: : tiêu dùng < 500.000d\nLevel 3 => Đại lý cấp 3: tiêu dùng < 1000.000d");
        }
    }
}
