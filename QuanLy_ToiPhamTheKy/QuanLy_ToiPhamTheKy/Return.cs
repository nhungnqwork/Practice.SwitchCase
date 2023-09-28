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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLy_ToiPhamTheKy
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-77LQJ4S;Initial Catalog=MafiaDb;Integrated Security=True");

        private void populate()
        {
            sqlConnection.Open();
            string query = "select MaKetAn,MaPhongGiam,MaPhamNhan,NgayThiHanh,NgayKetThuc,LenhKhoanHong from KetAnTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            RentDTGV.DataSource = data;
            sqlConnection.Close();
        }
        private void populateRent()
        {
            sqlConnection.Open();
            string query = "select * from NgayVeTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            ReturnDTGV.DataSource = data;
            sqlConnection.Close();
        }
        private void Deleteonreturn()
        {
            sqlConnection.Open();
            string query = "delete from KetAnTbl where MaPhongGiam='"+ MaPhongGiamCb.Text+ "'";
            SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Cập nhâp dữ liệu thành công!");
            sqlConnection.Close();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            populate();
            populateRent();
        }

        private void RentDTGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RentDTGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaPhongGiamCb.Text = RentDTGV.SelectedRows[0].Cells[1].Value.ToString();
            MaPNCb.Text = RentDTGV.SelectedRows[0].Cells[2].Value.ToString();
            dateNV.Text = RentDTGV.SelectedRows[0].Cells[4].Value.ToString();
            DateTime d1 = dateNV.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d1 - d2;
            int n = Convert.ToInt32(t.TotalDays);
            if (n <= 0)
            {
                DeplayTb.Text = "0 ngày";
                FineTb.Text = "0 tháng";
                yearTb.Text = "0 tháng";
            }
            else
            {
                DeplayTb.Text = "" + n;
                FineTb.Text = "Khoang: " + (n / 30) + " tháng";
                yearTb.Text = "Khoang: " + (n/365) + " năm";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdKATb.Text == "")
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string query = "insert into NgayVeTbl values ('" + IdKATb.Text + "', '" + MaPhongGiamCb.Text + "',  '" + MaPNCb.Text + "', '" + dateNV.Value.ToString() + "', '"+DeplayTb.Text+ "',  '"+FineTb.Text+"', '"+yearTb.Text+"')";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã duyệt thành công!");
                    sqlConnection.Close();
                    populateRent();
                    Deleteonreturn();
                    populate();
                }
                catch (Exception MyEx)
                {
                    MessageBox.Show($"{MyEx.Message}");
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Sentenced s = new Sentenced();
            s.ShowDialog();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Management_Criminal mc = new Management_Criminal();
            mc.Show();
            Hide();
        }
    }
}
