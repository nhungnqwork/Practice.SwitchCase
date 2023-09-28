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
    public partial class COMBO_FASTFOOD : Form
    {
        public COMBO_FASTFOOD()
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
            //balancelbl.Text = "Số dư còn lại " + data.Rows[0][0].ToString();
            bal = Convert.ToInt32(data.Rows[0][0].ToString());
            sqlConnection.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            Close();
        }
        #region Menu_Combo
        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Phần ăn có giá 50.000d\nBao gồm: Mì trộn 2 vắt, 2 Ốp la, Xúc xích.\nBạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 50)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 50;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation4();
                    combo1 s = new combo1();
                    s.Show();
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

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Phần ăn có giá 50.000d\n\nBao gồm: Cơm tấm, 1 Ốp la, 1 Chả, 1 miếng Sườn, 1 Pepsi.\nBạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 50)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 50;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation4();
                    combo2_3 s = new combo2_3();
                    s.Show();
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

        private void button19_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Phần ăn có giá 50.000d\n\nBao gồm: 1 Ức gà, 1 khoai chiên, 1 Pepsi.\nBạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 50)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 50;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation4();
                    combo2_3 s = new combo2_3();
                    s.Show();
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

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Phần ăn có giá 99.000d\n\nBao gồm: 1 hamburger, 2 gà rán, 1 Sting.\nBạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 99)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 99;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation5();
                    fastFood_cbSpecial s = new fastFood_cbSpecial();
                    s.Show();
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
        #endregion


        private void addTranstation4()
        {
            string TrType = "Mua thuc uong";
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
            }
        } //50

        private void addTranstation5()
        {
            string TrType = "Mua thuc uong";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 99 + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
            }
        } //100

        private void COMBO_FASTFOOD_Load(object sender, EventArgs e)
        {
            GetBalance();
        }
    }
}
