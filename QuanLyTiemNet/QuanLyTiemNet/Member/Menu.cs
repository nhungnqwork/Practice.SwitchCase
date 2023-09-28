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
    public partial class Menu : Form
    {
        public Menu()
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
            balancelbl.Text = "Số dư còn lại " + data.Rows[0][0].ToString();
            bal = Convert.ToInt32(data.Rows[0][0].ToString());
            sqlConnection.Close();
        }

        #region Menu
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thức uống có giá 15.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 15)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 15;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation1();
                    Sting s = new Sting();
                    s.Show();
                    this.Close();
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
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thức uống có giá 15.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 15)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 15;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation1();
                    C2 s = new C2();
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
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thức uống có giá 15.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 15)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 15;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation1();
                    DrThanh s = new DrThanh();
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
        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thức uống có giá 15.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 15)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 15;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation1();
                    No1 s = new No1();
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

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thức uống có giá 15.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 15)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 15;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation1();
                    Pepsi s = new Pepsi();
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
        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thức uống có giá 20.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 20)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 20;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation2();
                    cafe s = new cafe();
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

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thức uống có giá 20.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 20)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 20;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation2();
                    coffee_cream s = new coffee_cream();
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

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thức uống có giá 20.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 20)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 20;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation2();
                    coffee_cream s = new coffee_cream();
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

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thức uống có giá 15.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 15)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 15;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation1();
                    OrangeJuice s = new OrangeJuice();
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
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thức uống có giá 15.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 15)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 15;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation1();
                    TraTac s = new TraTac();
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
        private void button18_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Thức uống có giá 15.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 15)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 15;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation1();
                    water s = new water();
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
        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Đồ ăn có giá 20.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 20)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 20;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation2();
                    MiTron s = new MiTron();
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
        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Đồ ăn có giá 30.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 30)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 30;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation2();
                    ComTamSuon s = new ComTamSuon();
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
        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Đồ ăn có giá 15.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 15)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 15;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation1();
                    XucXich s = new XucXich();
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

        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Đồ ăn có giá 30.000d/100gr. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 30)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 30;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    sqlConnection.Close();
                    addTranstation3();
                    DaGa s = new DaGa();
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

        private void addTranstation1()
        {
            string TrType = "Mua thuc uong";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '-" + 15 + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
            }
        } //15

        private void addTranstation2()
        {
            string TrType = "Mua thuc uong";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '-" + 20 + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
            }
        } //20

        private void addTranstation3()
        {
            string TrType = "Mua thuc uong";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '-" + 30 + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
            }
        } //30
         
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Khi đồng ý mua đơn hàng, bạn có thể \n\nCLICK vào chữ ĐẶT HÀNG THÀNH CÔNG ĐỄ TRỞ LẠI");
            MessageBox.Show("Những ô có màu khác biệt thường sẽ nhận thêm phần thưởng");
            MessageBox.Show("Hãy luôn duy trì số dư đễ luôn nhận các món quà nhé!");
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            COMBO_FASTFOOD cbff = new COMBO_FASTFOOD(); 
            cbff.Show();
            Close();
        }
    }
}
