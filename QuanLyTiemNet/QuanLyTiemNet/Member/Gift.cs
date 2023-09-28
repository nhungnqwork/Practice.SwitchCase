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
    public partial class Gift : Form
    {
        public Gift()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        
        private void GetBalance()
        {
            sqlConnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where Level='" + giftRankLbl.Text + "'", sqlConnection);
            DataTable data = new DataTable();
            sda.Fill(data);
            sqlConnection.Close();
        }

        private void Gift_Load(object sender, EventArgs e)
        {
            giftRankLbl.Text = $"Cấp độ của bạn là: {SignUp.rankLbl}";
            GetBalance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gift2 gf2 = new gift2();
            gf2.Show();
            Close();
        }
        

        private void label4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            Close();
        }
    }
}
