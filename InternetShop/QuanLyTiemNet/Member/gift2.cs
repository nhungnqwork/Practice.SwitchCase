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
    public partial class gift2 : Form
    {
        public gift2()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        int bal;
        string Tdn = Login.TenDangNhap;

        private void gift2_Load(object sender, EventArgs e)
        {
            usernamelbl.Text = $"Chúc mừng, bạn {Login.TenNickName}";
            GetBalance();
        }
        
        private void GetBalance()
        {
            sqlConnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where UserName='" + Tdn + "'", sqlConnection);
            DataTable data = new DataTable();
            sda.Fill(data);
            bal = Convert.ToInt32(data.Rows[0][0].ToString());
            sqlConnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (bal > 0)
            {
                MessageBox.Show("Bạn không đủ điều kiện quy đổi");
            }
            else
            {
                int newBalance = bal + 5;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Nạp tiền thành công. Bạn được cộng 5.000d vào tài khoản của mình");
                    sqlConnection.Close();
                    addTranstation1();
                    Home h = new Home();
                    h.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void addTranstation1()
        {
            string TrType = "Phan qua cho nguoi moi";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 5 + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
                throw;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Close();
        }
    }
}
