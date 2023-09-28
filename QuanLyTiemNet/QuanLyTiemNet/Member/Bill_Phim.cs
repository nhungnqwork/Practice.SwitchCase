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
    public partial class Bill_Phim : Form
    {
        public Bill_Phim()
        {
            InitializeComponent();
        }
        private void Bill_Phim_Load(object sender, EventArgs e)
        {
            contentTb.Text = $"Ghế hiện tại của bạn là: {DatVeXemPhim.TenGhe}\n\nTên phim: {DatVeXemPhim.TenPhim}";
            foodlbl.Text = $"Combo kèm: \n{Menu_Film.combofood}";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Ministatement mn = new Ministatement();
            mn.Show();
            Close();
        }
    }
}
