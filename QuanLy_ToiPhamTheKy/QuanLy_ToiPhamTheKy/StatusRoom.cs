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

namespace QuanLy_ToiPhamTheKy
{
    public partial class StatusRoom : Form
    {
        public StatusRoom()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-77LQJ4S;Initial Catalog=MafiaDb;Integrated Security=True");
        Modify modify = new Modify();
        private void populate()
        {
            sqlConnection.Open();
            string query = "select * from QuanLyPhongGiamTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query,sqlConnection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            sttDTGV.DataSource = data;
            sqlConnection.Close();
        }
        private void populate1()
        {
            sqlConnection.Open();
            string query = "select MaPhongGiam,MaPhamNhan from NgayVeTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query,sqlConnection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            PNdtgv.DataSource = data;
            sqlConnection.Close();
        }
        private void populate2()
        {
            sqlConnection.Open();
            string query = "select MaSoPhong,TinhTrangPhong from PhongTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query,sqlConnection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            roomdtgv.DataSource = data;
            sqlConnection.Close();
        }
        private void populate4()
        {
            sqlConnection.Open();
            string query = "select * from PhongTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            roomdtgv.DataSource = data;
            sqlConnection.Close();
        }
        private void StatusRoom_Load(object sender, EventArgs e)
        {
            populate();
            populate1();
            populate2();
        }
        private void fill_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string flag = "";
            if (fill.SelectedItem.ToString() == "PHÒNG CÓ NGƯỜI")
            {
                flag = "NO";
            }
            sqlConnection.Open();
            string query = "select MaSoPhong,TinhTrangPhong from PhongTbl where TinhTrangPhong='" + flag + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            roomdtgv.DataSource = data;
            sqlConnection.Close();
        }

        private void roomdtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mpgTb.Text = roomdtgv.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = roomdtgv.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (name == "") //rong thi goi form 1 vao
            {
                StatusRoom_Load(sender, e);
            }
            else
            {
                string query = "Select MaPhongGiam,MaPhamNhan from NgayVeTbl Where MaPhongGiam like '%" + name + "%'";
                PNdtgv.DataSource = modify.Table(query);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mpgTb.Text == "" || slTb.Text == "" || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string query = "insert into QuanLyPhongGiamTbl values ('" + mpgTb.Text + "', '" + slTb.Text + "', '" + StatusCb.SelectedItem.ToString() + "')";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    sqlConnection.Close();
                    populate();
                }
                catch (Exception MyEx)
                {
                    MessageBox.Show($"{MyEx.Message}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate1();
            populate2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "update PhongTbl set MaSoPhong='" + mpgTb.Text + "', TinhTrangPhong='" + StatusCb.Text + "' where MaSoPhong='" + mpgTb.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Sửa tình trạng thành công!");
            sqlConnection.Close();
            populate4();
        }

        private void sttDTGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idQLPG.Text = sttDTGV.SelectedRows[0].Cells[0].Value.ToString();
            mpgTb.Text = sttDTGV.SelectedRows[0].Cells[1].Value.ToString();
            slTb.Text = sttDTGV.SelectedRows[0].Cells[2].Value.ToString();
            StatusCb.Text = sttDTGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            d.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "update QuanLyPhongGiamTbl set Id='" + idQLPG.Text + "', MaPhongGiam='"+ mpgTb.Text + "', SoLuongPN='" + slTb.Text + "', TinhTrang='" + StatusCb.Text + "' where Id='" + idQLPG.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Sửa tình trạng thành công!");
            sqlConnection.Close();
            populate();
        }
    }
}
