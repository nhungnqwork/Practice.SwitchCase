using Microsoft.Reporting.WinForms;
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
    public partial class Ministatement : Form
    {
        public Ministatement()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-77LQJ4S;Initial Catalog=TiemNetdb;Integrated Security=True");
        string Tdn = Login.TenDangNhap;
        private void populate()
        {
            sqlConnection.Open();
            //string query = "select * from TransactionTbl where UserName='" + Tdn + "'";
            string query = "select * from TransactionTbl where UserName='" + Tdn + "'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            data.Fill(tb);
            ministatementDGV.DataSource = tb;
            sqlConnection.Close();
        }

        private void Ministatement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReport fr= new FormReport();
            fr.Show();
            this.Hide();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LocalReport localReport = new LocalReport();
            localReport.ReportPath = Application.StartupPath + "\\Report2.rdlc";
            localReport.PrintToPrinter();
        }

        private void ministatementDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
