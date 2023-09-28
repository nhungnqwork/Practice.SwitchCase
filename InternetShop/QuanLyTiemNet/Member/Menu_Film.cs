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
    public partial class Menu_Film : Form
    {
        public Menu_Film()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        string Tdn = Login.TenDangNhap;
        int bal;
        public static string combofood;
        private void GetBalance()
        {
            sqlConnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where UserName='" + Tdn + "'", sqlConnection);
            DataTable data = new DataTable();
            sda.Fill(data);
            bal = Convert.ToInt32(data.Rows[0][0].ToString());
            sqlConnection.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();   
            Close();
        }

        private void Menu_Film_Load(object sender, EventArgs e)
        {
            contentTb.Text = $"Ghế hiện tại của bạn là: {DatVeXemPhim.TenGhe}\n\nTên phim: {DatVeXemPhim.TenPhim}";
            GetBalance();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult h = MessageBox.Show("Combo có giá 59.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 59)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                BGMcb.SelectedIndex = 0;
                int newBalance = bal - 59;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    combofood = BGMcb.Text;
                    sqlConnection.Close();
                    addTranstation1();
                    Load_Film lf = new Load_Film();
                    lf.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Hủy thành công!");
            }
        }
        private void addTranstation1()
        {
            string TrType = "Mua phan an rap chieu phim";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '-" + 59 + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult h = MessageBox.Show("Combo có giá 29.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 29)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                BGMcb.SelectedIndex = 1;
                int newBalance = bal - 29;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    combofood = BGMcb.Text;
                    sqlConnection.Close();
                    addTranstation2();
                    Load_Film lf = new Load_Film();
                    lf.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Hủy thành công!");
            }
        }

        private void addTranstation2()
        {
            string TrType = "Mua phan an rap chieu phim";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '-" + 29 + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult h = MessageBox.Show("Combo có giá 99.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 99)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                BGMcb.SelectedIndex = 2;
                int newBalance = bal - 99;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    combofood = BGMcb.Text;
                    sqlConnection.Close();
                    addTranstation3();
                    Load_Film lf = new Load_Film();
                    lf.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Hủy thành công!");
            }
        }
        private void addTranstation3()
        {
            string TrType = "Mua phan an rap chieu phim";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '-" + 99 + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult h = MessageBox.Show("Combo có giá 85.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 89)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                BGMcb.SelectedIndex = 3;
                int newBalance = bal - 85;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    combofood = BGMcb.Text;
                    sqlConnection.Close();
                    addTranstation4();
                    Load_Film lf = new Load_Film();
                    lf.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Hủy thành công!");
            }
        }
        private void addTranstation4()
        {
            string TrType = "Mua phan an rap chieu phim";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '-" + 85 + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult h = MessageBox.Show("Combo có giá 39.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 39)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                BGMcb.SelectedIndex = 4;
                int newBalance = bal - 39;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    combofood = BGMcb.Text;
                    sqlConnection.Close();
                    addTranstation5();
                    Load_Film lf = new Load_Film();
                    lf.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Hủy thành công!");
            }
        }
        private void addTranstation5()
        {
            string TrType = "Mua phan an rap chieu phim";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '-" + 39 + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult h = MessageBox.Show("Combo có giá 39.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 39)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                BGMcb.SelectedIndex = 5;
                int newBalance = bal - 39;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    combofood = BGMcb.Text;
                    sqlConnection.Close();
                    addTranstation5();
                    Load_Film lf = new Load_Film();
                    lf.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Hủy thành công!");
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult h = MessageBox.Show("Combo có giá 29.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 29)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                BGMcb.SelectedIndex = 6;
                int newBalance = bal - 29;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    combofood = BGMcb.Text;
                    sqlConnection.Close();
                    addTranstation2();
                    Load_Film lf = new Load_Film();
                    lf.Show();
                    Close(); ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Hủy thành công!");
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult h = MessageBox.Show("BIG COMBO có giá 139.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 139)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                BGMcb.SelectedIndex = 7;
                int newBalance = bal - 139;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    combofood = BGMcb.Text;
                    sqlConnection.Close();
                    addTranstation6();
                    Load_Film lf = new Load_Film();
                    lf.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Hủy thành công!");
            }
        }
        private void addTranstation6()
        {
            string TrType = "Mua phan an rap chieu phim";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '-" + 139 + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
            }
        }

    }
}
