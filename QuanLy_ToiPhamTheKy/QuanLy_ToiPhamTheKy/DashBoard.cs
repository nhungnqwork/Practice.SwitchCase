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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-77LQJ4S;Initial Catalog=MafiaDb;Integrated Security=True");
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.MaPhongGiam + Environment.NewLine + item.SoLuongPN;

                switch (item.MaPhongGiam)
                {
                    case "NO":
                        btn.BackColor = Color.DarkRed;
                        btn.ForeColor = Color.White; break;
                    default:
                        btn.BackColor = Color.LightBlue;
                        break;
                }
                flowLayoutPanel2.Controls.Add(btn);
            }
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            LoadTable();
            string query = "select Count(*) from PhongTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataTable data = new DataTable();
            da.Fill(data);
            pd10nLbl.Text = data.Rows[0][0].ToString();
            string query1 = "select Count(*) from PhongTbl where MucDo='" + "2 nam"+"'";
            SqlDataAdapter da1 = new SqlDataAdapter(query1, sqlConnection);
            DataTable data1 = new DataTable();
            da1.Fill(data1);
            stt2nLbl.Text = data1.Rows[0][0].ToString() + " Phòng";
            string query2 = "select Count(*) from PhongTbl where MucDo='" + "7 nam"+"'";
            SqlDataAdapter da2 = new SqlDataAdapter(query2, sqlConnection);
            DataTable data2 = new DataTable();
            da2.Fill(data2);
            label5.Text = data2.Rows[0][0].ToString() + " Phòng";
            string query3 = "select Count(*) from PhongTbl where MucDo='" + "10 nam"+"'";
            SqlDataAdapter da3 = new SqlDataAdapter(query3, sqlConnection);
            DataTable data3 = new DataTable();
            da3.Fill(data3);
            label9.Text = data3.Rows[0][0].ToString() + " Phòng";
            string query4 = "select Count(*) from PhongTbl where MucDo='" + "20 nam"+"'";
            SqlDataAdapter da4 = new SqlDataAdapter(query4, sqlConnection);
            DataTable data4 = new DataTable();
            da4.Fill(data4);
            label11.Text = data4.Rows[0][0].ToString() + " Phòng";
            string query5 = "select Count(*) from PhongTbl where MucDo='" + "25 nam"+"'";
            SqlDataAdapter da5 = new SqlDataAdapter(query5, sqlConnection);
            DataTable data5 = new DataTable();
            da5.Fill(data5);
            label12.Text = data5.Rows[0][0].ToString() + " Phòng";
            string query6 = "select Count(*) from PhongTbl where TinhTrangPhong='" + "WAITING" + "'";
            SqlDataAdapter da6 = new SqlDataAdapter(query6, sqlConnection);
            DataTable data6 = new DataTable();
            da6.Fill(data6);
            label15.Text = data6.Rows[0][0].ToString();
            string query7 = "select Count(*) from PhongTbl where MucDo='" + "2 nam"+"' and TinhTrangPhong='" + "WAITING" + "'";
            SqlDataAdapter da7 = new SqlDataAdapter(query7, sqlConnection);
            DataTable data7 = new DataTable();
            da7.Fill(data7);
            label16.Text= data7.Rows[0][0].ToString();
            string query8 = "select Count(*) from PhongTbl where MucDo='" + "7 nam"+"' and TinhTrangPhong='" + "WAITING" + "'";
            SqlDataAdapter da8 = new SqlDataAdapter(query8, sqlConnection);
            DataTable data8 = new DataTable();
            da8.Fill(data8);
            label17.Text = data8.Rows[0][0].ToString();
            string query9 = "select Count(*) from PhongTbl where MucDo='" + "10 nam" + "' and TinhTrangPhong='" + "WAITING" + "'";
            SqlDataAdapter da9 = new SqlDataAdapter(query9, sqlConnection);
            DataTable data9 = new DataTable();
            da9.Fill(data9);
            label22.Text = data9.Rows[0][0].ToString();
            string query10 = "select Count(*) from PhongTbl where MucDo='" + "20 nam" + "' and TinhTrangPhong='" + "WAITING" + "'";
            SqlDataAdapter da10 = new SqlDataAdapter(query10, sqlConnection);
            DataTable data10 = new DataTable();
            da10.Fill(data10);
            label19.Text = data10.Rows[0][0].ToString();
            string query11 = "select Count(*) from PhongTbl where MucDo='" + "25 nam" + "' and TinhTrangPhong='" + "WAITING" + "'";
            SqlDataAdapter da11 = new SqlDataAdapter(query11, sqlConnection);
            DataTable data11 = new DataTable();
            da11.Fill(data11);
            label24.Text = data11.Rows[0][0].ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Sentenced s =new Sentenced();
            s.Show();
            Close(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            r.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Criminal c = new Criminal();
            c.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatusRoom st = new StatusRoom();
            st.Show();
            Hide();
        }
    }
}
