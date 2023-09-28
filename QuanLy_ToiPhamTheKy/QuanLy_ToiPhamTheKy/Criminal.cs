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
    public partial class Criminal : Form
    {
        public Criminal()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-77LQJ4S;Initial Catalog=MafiaDb;Integrated Security=True");
        Modify modify = new Modify();
        QuanLyDanhSach quanLy;
        private void populate()
        {
            sqlConnection.Open();
            string query = "select * from PhamNhanTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            PhamNhandtgv.DataSource = data;
            sqlConnection.Close();
        }
        private void Criminal_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void PhamNhandtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iDTb.Text = PhamNhandtgv.SelectedRows[0].Cells[0].Value.ToString();
            nameTb.Text = PhamNhandtgv.SelectedRows[0].Cells[1].Value.ToString();
            dateTb.Text = PhamNhandtgv.SelectedRows[0].Cells[2].Value.ToString();
            actionTb.Text = PhamNhandtgv.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void GetValueTextBoxes()
        {
            string _id = iDTb.Text;
            string _hoTen = nameTb.Text;
            string _ngayThang = dateTb.Text;
            string _nguyenNhan = actionTb.Text;
            quanLy = new QuanLyDanhSach(_id, _hoTen, _ngayThang, _nguyenNhan);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (iDTb.Text == "" || nameTb.Text == "" || actionTb.Text == "")
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
            else
            {
                try
                {
                    GetValueTextBoxes();
                    sqlConnection.Open();
                    string query = "insert into PhamNhanTbl values ('" + quanLy.Id + "','" + quanLy.HoTen + "', '" + quanLy.NgayThang + "', '"+quanLy.NguyenNhan+"')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "update PhamNhanTbl set Id='" + iDTb.Text + "', Hovaten='" + nameTb.Text + "', NgayThang='" + dateTb.Text + "', NguyenNhan='"+actionTb.Text+"' where Id='" + iDTb.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công!");
            sqlConnection.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "delete from PhamNhanTbl where Id='" + iDTb.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công!");
            sqlConnection.Close();
            populate();
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string name = textBox_TimKiem.Text;
            if (name == "") //rong thi goi form 1 vao
            {
                Criminal_Load(sender, e);
            }
            else
            {
                string query = "Select * from PhamNhanTbl Where Id like '%" + name + "%'";
                PhamNhandtgv.DataSource = modify.Table(query);
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            Sentenced s = new Sentenced();
            s.Show();
            Close();
        }
    }
}
