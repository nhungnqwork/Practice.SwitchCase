using QuanLyTiemNet.DAO;
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
    public partial class PhongMay : Form
    {
        public PhongMay()
        {
            InitializeComponent();
            LoadTable();
        }
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;

                switch (item.Status)
                {
                    case "Available":
                        btn.BackColor = Color.LightBlue; break;
                    default:
                        btn.BackColor = Color.DarkRed;
                        btn.ForeColor = Color.White;
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            Close();
        }

        private void PhongMay_Load(object sender, EventArgs e)
        {

        }
    }
}
