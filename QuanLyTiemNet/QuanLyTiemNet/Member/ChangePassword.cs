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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        string Acc = Login.TenDangNhap;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Pass1Tb.Text == "" || Pass2Tb.Text == "")
            {
                MessageBox.Show("Có vẻ như bạn nhập thiếu !!");
            }
            else if(Pass2Tb.Text != Pass1Tb.Text)
            {
                MessageBox.Show("Mật khẩu không giống nhau");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string query = "update AccountTbl set Password='"+Pass1Tb.Text+"' where UserName='"+Acc+"'";
                    SqlCommand sqlCommand= new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cập nhập thành công");
                    sqlConnection.Close();
                    Login lo = new Login();
                    lo.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Lỗi: {Ex}");
                    throw;
                }
            }
        }
    }
}
