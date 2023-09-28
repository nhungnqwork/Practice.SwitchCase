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
    public partial class OrderMember : Form
    {
        public OrderMember()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        string Tdn = Login.TenDangNhap;
        Modify modify = new Modify();
        QuanLyDoanhThu quanly;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void thecaoCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (thecaoCb.SelectedIndex == 0)
                {
                    menhgiaTb.Text = "20";
                    ChietKhauTb.Text = "93";
                }
                if (thecaoCb.SelectedIndex == 1)
                {
                    menhgiaTb.Text = "50";
                    ChietKhauTb.Text = "95";
                }
                if (thecaoCb.SelectedIndex == 2)
                {
                    menhgiaTb.Text = "100";
                    ChietKhauTb.Text = "97";
                }
                if (thecaoCb.SelectedIndex == 3)
                {
                    menhgiaTb.Text = "200";
                    ChietKhauTb.Text = "97";
                }
                if (thecaoCb.SelectedIndex == 4)
                {
                    menhgiaTb.Text = "500";
                    ChietKhauTb.Text = "97";
                }
            }
        }

        private bool CheckTextBoxes()
        {
            if (thecaoCb.SelectedIndex == -1)
            {
                MessageBox.Show("Mời bạn chọn loại thẻ cào");
                return false;
            }
            else if (soluongTb.Text == "" || menhgiaTb.Text == "" || ChietKhauTb.Text == "" || usernameTb.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin");
                return false;
            }
            return true;
        }
        private void GetValueTextBoxes()
        {
            string _nhaMang = thecaoCb.Text; ;
            int _chietKhau = int.Parse(ChietKhauTb.Text);
            int _soLuong = int.Parse(soluongTb.Text);
            double _menhGia = double.Parse(menhgiaTb.Text);
            string _ngayThang = dateTimePicker1.Text;
            string _userName = usernameTb.Text;
            quanly = new QuanLyDoanhThu(_nhaMang, _chietKhau, _soLuong, _menhGia, _ngayThang, _userName);
        }
        private void OrderMember_Load(object sender, EventArgs e)
        {
            try
            {
                LC_dtgv.DataSource = modify.Table("select * from CardTbll");
                usernameTb.Text = $"{Login.TenDangNhap}";
                GetBalance();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error:{Ex}");
                throw;
            }

        }

        private void LC_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thecaoCb.SelectedItem = LC_dtgv.SelectedRows[0].Cells[1].Value.ToString();
            ChietKhauTb.Text = LC_dtgv.SelectedRows[0].Cells[2].Value.ToString();
            soluongTb.Text = LC_dtgv.SelectedRows[0].Cells[3].Value.ToString();
            menhgiaTb.Text = LC_dtgv.SelectedRows[0].Cells[4].Value.ToString();

        }


        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string name = textBox_TimKiem.Text;
            if (name == "") //rong thi goi form 1 vao
            {
                OrderMember_Load(sender, e);
            }
            else
            {
                string query = "Select * from CardTbll Where UserName like '%" + name + "%'";
                LC_dtgv.DataSource = modify.Table(query);
            }
        }

        private void Addbtn_Click_1(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValueTextBoxes();
                string query = "insert into CardTbll values ('" + quanly.NhaMang + "', '" + quanly.ChietKhau + "', '" + quanly.SoLuong + "', '" + quanly.MenhGia + "', '" + quanly.TongTien() + "', '" + dateTimePicker1.Value.ToString() + "', '" + quanly.UserName + "')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm thẻ không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm thẻ thành công");
                        OrderMember_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    throw;
                }
            }
        }

        private void GetBalance()
        {
            sqlConnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where FullName='" + Tdn + "' ", sqlConnection);
            DataTable data = new DataTable();
            sda.Fill(data);
            sqlConnection.Close();
        }

        private void soluongTb_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
