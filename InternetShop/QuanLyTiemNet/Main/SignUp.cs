using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemNet
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        public static string rankLbl;
        public static string tKMT; //tai khoai moi tao
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (fullnameTb.Text == "" || usernameTb.Text == "" || AddressTb.Text == "" || passwordTb.Text == "" || levelCB.SelectedIndex == -1 || PhoneTb.Text == "" || passwordTb.Text == "")
            {
                MessageBox.Show("Hình như bạn thiếu thông tin gì đó");
            }
            else
            {
                try
                {
                    int bal = 0;
                    sqlConnection.Open();
                    string query = "insert into AccountTbl values('" + usernameTb.Text + "', '" + fullnameTb.Text + "', '" + dobdate.Value.Date + "', '" + PhoneTb.Text + "' ,'" + AddressTb.Text + "', '" + levelCB.SelectedIndex.ToString() + "', " + bal + ", '" + passwordTb.Text + "')";
                    SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo tài khoản thành công!");
                    rankLbl = levelCB.Text;
                    tKMT = usernameTb.Text;
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                    MessageBox.Show("Đừng quên thay đổi mật khẩu khi tài khoản vừa được tạo nhé!!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Error: {Ex}");
                    throw;
                }
                sqlConnection.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có thực sự muốn thoát thông", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (h == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void PhoneTb_KeyPress(object sender, KeyPressEventArgs e)
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
