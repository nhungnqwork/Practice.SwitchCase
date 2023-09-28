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
    public partial class fastFood_cbSpecial : Form
    {
        public fastFood_cbSpecial()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        string Tdn = Login.TenDangNhap;
        int bal;
        private void GetBalance()
        {
            sqlConnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where UserName='" + Tdn + "'", sqlConnection);
            DataTable data = new DataTable();
            sda.Fill(data);
            bal = Convert.ToInt32(data.Rows[0][0].ToString());
            sqlConnection.Close();
        }
        private void fastFood_cbSpecial_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void addTranstation1()
        {
            string TrType = "Tien thuong";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 11 + "', '" + DateTime.Today.Date.ToString() + "')";
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

        private void label1_Click(object sender, EventArgs e)
        {
            if (bal < 0)
            {
                MessageBox.Show("Bạn không đủ điều kiện quy đổi");
                Menu m = new Menu();
                m.Show();
                Close();
            }
            else
            {
                int newBalance = bal + 11;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Nạp tiền thành công. Bạn được cộng 11.000d vào tài khoản của mình");
                    sqlConnection.Close();
                    addTranstation1();
                    Menu h = new Menu();
                    h.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
