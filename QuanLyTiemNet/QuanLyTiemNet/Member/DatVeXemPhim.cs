using QuanLyTiemNet.DAO;
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
    public partial class DatVeXemPhim : Form
    {
        public DatVeXemPhim()
        {
            InitializeComponent();
            LoadTable();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        string Tdn = Login.TenDangNhap;
        public static string TenGhe;
        public static string TenPhim;
        int bal;

        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableFilm();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.ScreenWidth, Height = TableDAO.ScreenHeight };
                btn.Text = item.Name;

                switch (item.Status)
                {
                    case "Available":
                        btn.BackColor = Color.LightGreen;
                        btn.ForeColor = Color.Black;
                        break;
                    default:
                        btn.BackColor = Color.DarkRed;
                        btn.ForeColor = Color.White;
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
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
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Vé xem phim có giá 120.000d. Bạn sẽ gọi món không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (bal < 120)
            {
                MessageBox.Show("Bạn không đủ số dư đễ quy đổi");
            }
            else if (filmCb.Text == "" || nameTb.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn film");
            }
            else if (h == DialogResult.OK)
            {
                int newBalance = bal - 120;
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Balance='" + newBalance + "' where UserName='" + Tdn + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    TenGhe = nameTb.Text;
                    TenPhim = filmCb.Text;
                    sqlConnection.Close();
                    addTranstation1();
                    Menu_Film s = new Menu_Film();
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

        private void addTranstation1()
        {
            string TrType = "Dat ve xem phim";
            try
            {
                sqlConnection.Open();
                string query = "insert into TransactionTbl values('" + Tdn + "', '" + TrType + "',  '" + 120 + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error: {Ex}");
            }
        }

        private void DatVeXemPhim_Load(object sender, EventArgs e)
        {
            GetBalance();
        }
    }
}
