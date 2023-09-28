using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemNet
{
    public partial class ListCard : Form
    {
        public ListCard()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        QuanLyDoanhThu quanly;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Page_Admin h = new Page_Admin();
            h.Show();
            Close();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            else if(soluongTb.Text == "" || menhgiaTb.Text == "" || ChietKhauTb.Text == "" || usernameTb.Text == "")
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

        private void ListCard_Load(object sender, EventArgs e)
        {
            try
            {
                LC_dtgv.DataSource = modify.Table("select * from CardTbll");
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error:{Ex}");
                throw;
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValueTextBoxes();
                string query = "insert into CardTbll values ('"+quanly.NhaMang+"', '"+quanly.ChietKhau+"', '"+quanly.SoLuong+"', '"+quanly.MenhGia+"', '"+quanly.TongTien()+"', '"+dateTimePicker1.Value.ToString()+"', '"+quanly.UserName+"')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm thẻ không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm thẻ thành công");
                        ListCard_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    throw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LC_dtgv.Rows.Count > 1) // ham xoa phai chua lai 1 hang *bat buoc phai co
            {
                string choose = LC_dtgv.SelectedRows[0].Cells[0].Value.ToString();

                string query = "DELETE CardTbll ";
                query += "WHERE Id='" + choose + "'";

                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa thẻ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query); //cau truy van
                        MessageBox.Show("Xóa thành công!");
                        ListCard_Load(sender, e);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error delete: " + ex.Message);
                    throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValueTextBoxes();
                string query = "UPDATE CardTbll SET TenNhaMang = N'" + quanly.NhaMang + "', ChietKhau= " + quanly.ChietKhau + " , SoLuong= " + quanly.SoLuong + " , MenhGia=   " + quanly.MenhGia + " ,TongTien= " + quanly.TongTien() + " ";
                query += " WHERE TenNhamang ='" + quanly.NhaMang + "'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn chỉnh sửa loại thẻ này không?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query); //cau truy van
                        MessageBox.Show("Sửa thành công!");
                        ListCard_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error update: " + ex.Message);
                    throw;
                }
            }
        }

        private void LC_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thecaoCb.SelectedItem = LC_dtgv.SelectedRows[0].Cells[1].Value.ToString();
            ChietKhauTb.Text = LC_dtgv.SelectedRows[0].Cells[2].Value.ToString();
            soluongTb.Text = LC_dtgv.SelectedRows[0].Cells[3].Value.ToString();
            menhgiaTb.Text = LC_dtgv.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void soluongTb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox_TimKiem.Text;
            if (name == "") //rong thi goi form 1 vao
            {
                ListCard_Load(sender, e);
            }
            else
            {
                string query = "Select * from CardTbll Where UserName like '%" + name + "%'";
                LC_dtgv.DataSource = modify.Table(query);
            }
        }
    }
}
