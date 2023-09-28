using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_ToiPhamTheKy
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-77LQJ4S;Initial Catalog=MafiaDb;Integrated Security=True");
        Modify modify= new Modify();
        private void populate()
        {
            sqlConnection.Open();
            string query = "select * from PhongTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            PhongGiam_DTGV.DataSource = data;
            sqlConnection.Close();
        }
        private void fillAvailable()
        {
            sqlConnection.Open();
            string query = "select TinhTrangPhong from PhongTbl";
            // where TinhTrangPhong='"+"YES"+"'
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader rdr;
            rdr = sqlCommand.ExecuteReader();
            DataTable data = new DataTable();
            data.Columns.Add("TinhTrangPhong", typeof(string));
            data.Load(rdr);
            fill.ValueMember = "TinhTrangPhong";
            fill.DataSource = data;
            sqlConnection.Close();
        }
        private void Room_Load(object sender, EventArgs e)
        {
            populate();
            //fillAvailable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || ActionTb.Text == "" || StatusCb.SelectedIndex == -1 || LevelTb.Text == "")
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string query = "insert into PhongTbl values ('" + IdTb.Text + "', '" + ActionTb.Text + "', '" + StatusCb.SelectedItem.ToString() + "', '" + LevelTb.Text + "')";
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

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "delete from PhongTbl where MaSoPhong='" + IdTb.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công!");
            sqlConnection.Close();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "update PhongTbl set MaSoPhong='" + IdTb.Text + "', HanhViPhamToi='" + ActionTb.Text + "', TinhTrangPhong='" + StatusCb.Text + "' where MaSoPhong='" + IdTb.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công!");
            sqlConnection.Close();
            populate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox_TimKiem.Text;
            if (name == "") //rong thi goi form 1 vao
            {
                Room_Load(sender, e);
            }
            else
            {
                string query = "Select * from PhongTbl Where HanhViPhamToi like '%" + name + "%'";
                PhongGiam_DTGV.DataSource = modify.Table(query);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Sentenced s = new Sentenced();
            s.Show();
            Close();
        }

        private void PhongGiam_DTGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTb.Text = PhongGiam_DTGV.SelectedRows[0].Cells[0].Value.ToString();
            ActionTb.Text = PhongGiam_DTGV.SelectedRows[0].Cells[1].Value.ToString();
            StatusCb.Text = PhongGiam_DTGV.SelectedRows[0].Cells[2].Value.ToString();
            LevelTb.Text = PhongGiam_DTGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (name == "") //rong thi goi form 1 vao
            {
                Room_Load(sender, e);
            }
            else
            {
                string query = "Select * from PhongTbl Where MaSoPhong like '%" + name + "%'";
                PhongGiam_DTGV.DataSource = modify.Table(query);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void fill_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string flag = "";
            if (fill.SelectedItem.ToString() == "TRỐNG")
            {
                flag = "WAITING";
            }
            else
            {
                flag = "NO";
            }
            sqlConnection.Open();
            string query = "select * from PhongTbl where TinhTrangPhong='"+flag+"'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            PhongGiam_DTGV.DataSource = data;
            sqlConnection.Close();
        }
    }
}
