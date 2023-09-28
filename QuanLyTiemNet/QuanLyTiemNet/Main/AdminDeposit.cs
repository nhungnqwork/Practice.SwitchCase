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
    public partial class AdminDeposit : Form
    {
        public AdminDeposit()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "select count(*) from AccountTbl where Address='" + addressTb.Text + "'";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlAdapter.Fill(data);
            sqlConnection.Close();
            if (data.Rows[0][0].ToString() == "1")
            {
                Page_Admin h = new Page_Admin();
                h.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai mật khẩu");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chúng tôi đã gửi 1 mã xác nhận đến đại lý của bạn, hãy liên hệ đễ truy cập");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            Close();
        }
    }
}
