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
    public partial class fastcash : Form
    {
        public fastcash()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        int bal;
        string Tdn = Login.TenDangNhap;

        private void GetBalance()
        {
            sqlConnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where UserName='" + Tdn + "'", sqlConnection);
            DataTable data = new DataTable();
            sda.Fill(data);
            balancelbl.Text = "Số dư còn lại " + data.Rows[0][0].ToString();
            bal = Convert.ToInt32(data.Rows[0][0].ToString());
            sqlConnection.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn sẽ quy đổi từ số tiền trong tài khoản sang giờ chơi\nBảng giá: 10.000VND/1h");
        }
        private void fastcash_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bal < 10)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else
            {
                int newBalance = bal - 10;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Nạp tiền thành công. Bạn được cộng 1 giờ vào tài khoản của mình");
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
            string TrType = "Quy doi gio choi";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 10 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (bal < 20)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else
            {
                int newBalance = bal - 20;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Nạp tiền thành công. Bạn được cộng 2 giờ vào tài khoản của mình");
                    sqlConnection.Close();
                    addTranstation2();
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
        private void addTranstation2()
        {
            string TrType = "Quy doi gio choi";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 20 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (bal < 30)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else
            {
                int newBalance = bal - 30;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Nạp tiền thành công. Bạn được cộng 3 giờ vào tài khoản của mình");
                    sqlConnection.Close();
                    addTranstation3();
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
        private void addTranstation3()
        {
            string TrType = "Quy doi gio choi";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 30 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (bal < 50)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else
            {
                int newBalance = bal - 50;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Nạp tiền thành công. Bạn được cộng 5 giờ vào tài khoản của mình");
                    sqlConnection.Close();
                    addTranstation4();
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

        private void addTranstation4()
        {
            string TrType = "Quy doi gio choi";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 50 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (bal < 70)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else
            {
                int newBalance = bal - 70;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Nạp tiền thành công. Bạn được cộng 7 giờ vào tài khoản của mình");
                    sqlConnection.Close();
                    addTranstation5();
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
        private void addTranstation5()
        {
            string TrType = "Quy doi gio choi";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 70 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else
            {
                int newBalance = bal - 100;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Nạp tiền thành công. Bạn được cộng 10 giờ vào tài khoản của mình");
                    sqlConnection.Close();
                    addTranstation6();
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
        private void addTranstation6()
        {
            string TrType = "Quy doi gio choi";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 100 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (bal < 130)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else
            {
                int newBalance = bal - 130;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Nạp tiền thành công. Bạn được cộng 15 giờ vào tài khoản của mình");
                    sqlConnection.Close();
                    addTranstation7();
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
        private void addTranstation7()
        {
            string TrType = "Quy doi gio choi";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 130 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void button8_Click(object sender, EventArgs e)
        {
            if (bal < 255)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else
            {
                int newBalance = bal - 255;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Nạp tiền thành công. Bạn được cộng 30 giờ vào tài khoản của mình");
                    sqlConnection.Close();
                    addTranstation8();
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

        private void addTranstation8()
        {
            string TrType = "Quy doi gio choi";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 255 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (bal < 405)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else
            {
                int newBalance = bal - 405;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Nạp tiền thành công. Bạn được cộng 50 giờ vào tài khoản của mình");
                    sqlConnection.Close();
                    addTranstation9();
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
        private void addTranstation9()
        {
            string TrType = "Quy doi gio choi";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 405 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            personal_Information pi = new personal_Information();
            pi.Show();
            Close();
        }
    }
}
