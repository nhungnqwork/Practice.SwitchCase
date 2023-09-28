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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        string Tdn = Login.TenDangNhap;

        private void Deposit_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Chúng tôi đã gửi mã CODE đến đại lý, vui lòng liên hệ để nhận");
            GetBalance();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Page_Admin h = new Page_Admin();
            h.Show();
            Close();
        }
        private void addTranstation()
        {
            string TrType = "Nap tien";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + DepoAmtTb.Text + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                //MessageBox.Show("Create successfully!!");
                sqlConnection.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DepoAmtTb.Text == "" || Convert.ToInt32(DepoAmtTb.Text) <= 0)
            {
                MessageBox.Show("Hãy nhập đủ thông tin hoặc liên hệ đại lý gần nhất");
            }
            else
            {
                newBalance = oldBalance + Convert.ToInt32(DepoAmtTb.Text);
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã nạp tiền thành công");
                    sqlConnection.Close();
                    addTranstation();
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        int oldBalance, newBalance;
        private void GetBalance()
        {
            sqlConnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where UserName='" + Tdn + "'", sqlConnection);
            DataTable data = new DataTable();
            sda.Fill(data);
            oldBalance = Convert.ToInt32(data.Rows[0][0].ToString());
            sqlConnection.Close();
        }
    }
}
