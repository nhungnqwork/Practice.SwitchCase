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
    public partial class Admin_PhongMay : Form
    {
        public Admin_PhongMay()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        QuanLyPhongNet quanLy;

        private void Admin_PhongMay_Load(object sender, EventArgs e)
        {
            try
            {
                PhongMay_dtgv.DataSource = modify.Table("select * from TableNet");
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error:{Ex}");
            }
        }

        private bool CheckTextBoxes()
        {
            if (nameTb.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin");
                return false;
            }
            else if(statusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Mời bạn chọn tình trạng máy");
                return false;
            }
            return true;
        }

        private void GetValueTextBoxes()
        {
            string _name = nameTb.Text; ;
            string _status = statusCb.Text;
            quanLy = new QuanLyPhongNet(_name, _status);
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValueTextBoxes();
                string query = "INSERT INTO TableNet VALUES ('" + quanLy.Name + "', '" + quanLy.Status + "')";
                try
                {
                    if (MessageBox.Show("Ban co thuc su muon them ?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        modify.Command(query);
                        MessageBox.Show("Them thanh cong");
                        Admin_PhongMay_Load(sender, e);
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
            if (PhongMay_dtgv.Rows.Count > 1) // ham xoa phai chua lai 1 hang *bat buoc phai co
            {
                string choose = PhongMay_dtgv.SelectedRows[0].Cells[0].Value.ToString();

                string query = "DELETE TableNet ";
                query += "WHERE Id='" + choose + "'";

                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query); //cau truy van
                        MessageBox.Show("Xóa thành công!");
                        Admin_PhongMay_Load(sender, e);
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
                string query = "UPDATE TableNet SET name = '" + quanLy.Name + "', status='" + quanLy.Status + "'";
                query += " WHERE name='" + quanLy.Name + "'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn chỉnh sửa loại thẻ này không?", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query); //cau truy van
                        MessageBox.Show("Sửa thành công!");
                        Admin_PhongMay_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error update: " + ex.Message);
                    throw;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Page_Admin h = new Page_Admin();
            h.Show();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PhongMay pm = new PhongMay();
            pm.Show();
        }

        private void PhongMay_dtgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            nameTb.Text = PhongMay_dtgv.SelectedRows[0].Cells[1].Value.ToString();
            statusCb.SelectedItem = PhongMay_dtgv.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
