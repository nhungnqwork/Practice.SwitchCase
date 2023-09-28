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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyTiemNet
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        public static string SoDuTaiKhoan;
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        private void GetBalance()
        {
            sqlConnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where UserName='" + usernamelbl.Text + "'", sqlConnection);
            DataTable data = new DataTable();
            sda.Fill(data);
            balancelb.Text = data.Rows[0][0].ToString();
            sqlConnection.Close();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            usernamelbl.Text = $"{Login.TenDangNhap}";
            GetBalance();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            Close();
        }
    }
}
