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
    public partial class Sentenced : Form
    {
        public Sentenced()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-77LQJ4S;Initial Catalog=MafiaDb;Integrated Security=True");
        Modify modify= new Modify();
        /*void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.MaPhongGiam + Environment.NewLine + item.SoLuongPN;

                switch (item.MaPhongGiam)
                {
                    case "NO":
                        btn.BackColor = Color.DarkRed;
                        btn.ForeColor = Color.White; break;
                    default:
                        btn.BackColor = Color.LightBlue;
                        break;
                }
                flowLayoutPanel2.Controls.Add(btn);
            }
        }*/
        private void fillcombo()
        {
            sqlConnection.Open();
            string query = "select MaSoPhong from PhongTbl";
            // where TinhTrangPhong='"+"YES"+"'
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader rdr;
            rdr = sqlCommand.ExecuteReader();
            DataTable data = new DataTable();
            data.Columns.Add("MaSoPhong", typeof(string));
            data.Load(rdr);
            PhongGiamCb.ValueMember = "MaSoPhong";
            PhongGiamCb.DataSource = data;
            sqlConnection.Close();
        }

        private void fillCustName()
        {
            sqlConnection.Open();
            string query = "select Id from PhamNhanTbl";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader rdr;
            rdr = sqlCommand.ExecuteReader();
            DataTable data = new DataTable();
            data.Columns.Add("Id", typeof(string));
            data.Load(rdr);
            PNCb.ValueMember = "Id";
            PNCb.DataSource = data;
            sqlConnection.Close();
        }

        private void fetchCustomer()
        {
            sqlConnection.Open();
            string query = "select * from PhamNhanTbl where Id='" + PNCb.SelectedValue.ToString() + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            DataTable data = new DataTable();
            SqlDataAdapter rdr = new SqlDataAdapter(sqlCommand);
            rdr.Fill(data);
            foreach (DataRow dr in data.Rows)
            {
                NameTb.Text = dr["Hovaten"].ToString();
            }
            sqlConnection.Close();
        }
        private void populate()
        {
            sqlConnection.Open();
            string query = "select Id,HovaTen,NgayThang,NguyenNhan from PhamNhanTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            NN_dtgv.DataSource = data;
            sqlConnection.Close();
        }
        private void populate2()
        {
            sqlConnection.Open();
            string query = "select MaSoPhong,HanhViPhamToi,MucDo from PhongTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            MucDo_dtgv.DataSource = data;
            sqlConnection.Close();
        }
        private void populate3()
        {
            sqlConnection.Open();
            string query = "select * from KetAnTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            KetAn_DTGV.DataSource = data;
            sqlConnection.Close();
        }

        private void populate4()
        {
            sqlConnection.Open();
            string query = "insert into BaoTonThongTinPNTbl values ('" + PNCb.Text + "', '" + NameTb.Text + "', '" + datePN.Value.ToString() + "',  '" + nguyenNhanTb.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Đã lưu sang bảo tồn thông tin");
            sqlConnection.Close();
        }
        private void UpdateonRent()
        {
            sqlConnection.Open();
            string query = "update PhongTbl set TinhTrangPhong='" + "NO" + "' where MaSoPhong= '" + PhongGiamCb.SelectedValue.ToString() + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        private void UpdateonRentDelete()
        {
            sqlConnection.Open();
            string query = "update PhongTbl set TinhTrangPhong='" + "WAITING" + "' where MaSoPhong= '" + PhongGiamCb.SelectedValue.ToString() + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        private void Sentenced_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustName();
            populate();
            populate2();
            populate3();
            UpdateonRent();
        }

        private void NN_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PNCb.Text = NN_dtgv.SelectedRows[0].Cells[0].Value.ToString();
            NameTb.Text = NN_dtgv.SelectedRows[0].Cells[1].Value.ToString();
            datePN.Text = NN_dtgv.SelectedRows[0].Cells[2].Value.ToString();
            nguyenNhanTb.Text = NN_dtgv.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void MucDo_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PhongGiamCb.Text = MucDo_dtgv.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void PNCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustomer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdKATb.Text == "" || PhongGiamCb.SelectedIndex == -1 || PNCb.SelectedIndex == -1 || NameTb.Text == "" || nguyenNhanTb.Text == "" || khoanHongTb.Text == "")
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string query = "insert into KetAnTbl values ('" + IdKATb.Text + "','" + PhongGiamCb.SelectedValue.ToString() + "', '" + PNCb.SelectedValue.ToString() + "', '" + NameTb.Text + "', '" + date1Tb.Value.ToString() + "', '" + date2Tb.Value.ToString() + "', '" + nguyenNhanTb.Text + "', '" + khoanHongTb.Text + "', '"+datePN.Value.ToString()+"')";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    sqlConnection.Close();
                    UpdateonRent();
                    populate3();
                }
                catch (Exception MyEx)
                {
                    MessageBox.Show($"{MyEx.Message}");
                }
            }
        }
        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string name = textBox_TimKiem.Text;
            if (name == "")
            {
                Sentenced_Load(sender, e);
            }
            else
            {
                string query = "Select * from PhamNhanTbl Where Id like '%" + name + "%'";
                NN_dtgv.DataSource = modify.Table(query);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            if (name == "")
            {
                Sentenced_Load(sender, e);
            }
            else
            {
                string query = "Select * from PhongTbl Where HanhViPhamToi like '%" + name + "%'";
                MucDo_dtgv.DataSource = modify.Table(query);
            }
        }
        QuanLyDanhSach quanly;
        private void GetValueTextBoxes()
        {
            string _id = PNCb.Text;
            string _hoTen = NameTb.Text;
            string _ngayThang = date2Tb.Text;
            string _nguyenNhan = nguyenNhanTb.Text;
            quanly = new QuanLyDanhSach(_id, _hoTen, _ngayThang, _nguyenNhan);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            GetValueTextBoxes();
            sqlConnection.Open();
            string query = "delete from PhamNhanTbl where Id='" + quanly.Id + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công!");
            sqlConnection.Close();
            populate4();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IdKATb.Text = "";
            PhongGiamCb.SelectedIndex = -1;
            PNCb.SelectedIndex = -1;
            NameTb.Text = "";
            nguyenNhanTb.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormReport fr = new FormReport();
            fr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Image_Prison ip = new Image_Prison();
            ip.Show();
        }

        private void KetAn_DTGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdKATb.Text = KetAn_DTGV.SelectedRows[0].Cells[0].Value.ToString();
            PhongGiamCb.Text = KetAn_DTGV.SelectedRows[0].Cells[1].Value.ToString();
            PNCb.Text = KetAn_DTGV.SelectedRows[0].Cells[2].Value.ToString();
            NameTb.Text = KetAn_DTGV.SelectedRows[0].Cells[3].Value.ToString();
            date1Tb.Text = KetAn_DTGV.SelectedRows[0].Cells[4].Value.ToString();
            date2Tb.Text = KetAn_DTGV.SelectedRows[0].Cells[5].Value.ToString();
            nguyenNhanTb.Text = KetAn_DTGV.SelectedRows[0].Cells[6].Value.ToString();
            khoanHongTb.Text = KetAn_DTGV.SelectedRows[0].Cells[7].Value.ToString();
            datePN.Text = KetAn_DTGV.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "update KetAnTbl set MaKetAn='" + IdKATb.Text + "', MaphongGiam='" + PhongGiamCb.Text + "', MaPhamNhan='" + PNCb.Text + "', HoTenPhamNhan='" + NameTb.Text + "', NgayThiHanh='" + date1Tb.Value.ToString() + "', NgayKetThuc='" + date2Tb.Value.ToString() + "', NguyenNhan='" + nguyenNhanTb.Text + "', LenhKhoanHong='" + khoanHongTb.Text + "', NgaySinh='" + datePN.Value.ToString() + "' where MaKetAn='" + IdKATb.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công!");
            sqlConnection.Close();
            populate3();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Return r = new Return();
            r.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            db.Show();
        }
    }
}
