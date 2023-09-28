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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-77LQJ4S;Initial Catalog=MafiaDb;Integrated Security=True");

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (passTb.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu của bạn!");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string query = "select * from password where password='" + passTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    DataTable data = new DataTable();
                    sqlDataAdapter.Fill(data);
                    sqlConnection.Close();
                    if (data.Rows[0][0].ToString() == "1")
                    {
                        Splash s = new Splash();
                        s.ShowDialog();
                        Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sai mật khẩu!");
                }
                
            }
        }

        private void passTb_KeyPress(object sender, KeyPressEventArgs e)
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
