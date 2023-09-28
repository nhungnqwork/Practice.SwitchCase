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
    public partial class CheckBill : Form
    {
        public CheckBill()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        Modify modify = new Modify();
        QuanLyHoaDon quanly;


        private void CheckBill_Load(object sender, EventArgs e)
        {
            try
            {
                ministatementDGV.DataSource = modify.Table("select * from TransactionTbl");
                check_dtgv.DataSource = modify.Table("select * from CheckedAdmin");
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Error:{Ex}");
                throw;
            }
        }

        private void GetValueTextBoxes()
        {
            int _id = int.Parse(idTb.Text);
            string _userName = usernameTb.Text;
            string _type = typeTb.Text;
            string _amount = amountTb.Text;
            string _date = dateTb.Text;
            string _checked = checkTb.Text;
            quanly = new QuanLyHoaDon(_id,_userName,_type,_amount, _date, _checked);
        }

        private void ministatementDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTb.Text = ministatementDGV.SelectedRows[0].Cells[0].Value.ToString();
            usernameTb.Text = ministatementDGV.SelectedRows[0].Cells[1].Value.ToString();
            typeTb.Text = ministatementDGV.SelectedRows[0].Cells[2].Value.ToString();
            amountTb.Text = ministatementDGV.SelectedRows[0].Cells[3].Value.ToString();
            dateTb.Text = ministatementDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Close();
        }
        private bool CheckTextBoxes()
        {
            return true;
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            //INSERT
            if (CheckTextBoxes())
            {
                GetValueTextBoxes();
                string query = "insert into CheckedAdmin values ('" + quanly.Id + "', '" + quanly.UserName + "', '" + quanly.Type + "', '" + quanly.Amount + "', '" + dateTb.Value.ToString() + "', '" + quanly.Checked + "')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm dữ liệu này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm thẻ thành công");
                        CheckBill_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    throw;
                }
            }
        }

        private void TimKiemtb_TextChanged(object sender, EventArgs e)
        {
            string name = TimKiemtb.Text;
            if (name == "")
            {
                CheckBill_Load(sender, e);
            }
            else
            {
                string query = "Select * from CheckedAdmin Where UserName like '%" + name + "%'";
                check_dtgv.DataSource = modify.Table(query);
            }
        }

        private void timkiemTbcustomer_TextChanged(object sender, EventArgs e)
        {
            string name2 = customerTk.Text;
            if (name2 == "")
            {
                CheckBill_Load(sender, e);
            }
            else
            {
                string query = "Select * from TransactionTbl Where Tid like '%" + name2 + "%'";
                ministatementDGV.DataSource = modify.Table(query);
            }
        }

        private void usernameTb_Click(object sender, EventArgs e)
        {
            
        }
    }
}
