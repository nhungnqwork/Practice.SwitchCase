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
    public partial class Management_Criminal : Form
    {
        public Management_Criminal()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-77LQJ4S;Initial Catalog=MafiaDb;Integrated Security=True");

        private void Management_Criminal_Load(object sender, EventArgs e)
        {
            populate();
            populate1();
            populate2();
        }
        private void populate()
        {
            sqlConnection.Open();
            string query = "select MaPhongGiam,MaPhamNhan,NgayVe from NgayVeTbl";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            NgayVedtgv.DataSource = data;
            sqlConnection.Close();
        }
        private void populate1()
        {
            sqlConnection.Open();
            string query = "select * from QuanLyPhongGiamTbl";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            QuanLydtgv.DataSource = data;  
            sqlConnection.Close();  
        }
        private void populate2()
        {
            sqlConnection.Open();
            string query = "select * from PhongTbl";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            phongDTGV.DataSource = data;  
            sqlConnection.Close();  
        }
        private void UpdateonRent()
        {
            sqlConnection.Open();
            string query = "update PhongTbl set TinhTrangPhong='" + "YES" + "' where MaSoPhong= '" + IdKATb.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateonRent();
            populate2();
        }

        private void phongDTGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdKATb.Text = phongDTGV.SelectedRows[0].Cells[0].Value.ToString();
            ActionTb.Text = phongDTGV.SelectedRows[0].Cells[1].Value.ToString();
            StatusCb.Text = phongDTGV.SelectedRows[0].Cells[2].Value.ToString();
            LevelTb.Text = phongDTGV.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
