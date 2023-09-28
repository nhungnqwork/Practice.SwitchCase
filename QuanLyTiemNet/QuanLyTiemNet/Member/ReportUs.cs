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
    public partial class ReportUs : Form
    {
        public ReportUs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ycTb.Text == "")
            {
                MessageBox.Show("Mời bạn nhập nội dung");
            }
            else
            {
                MessageBox.Show("Bạn đã gửi yêu cầu thành công. Chúng tôi sẽ phản hồi đến bạn trong vòng 5 phút nữa!!");

                DialogResult h = MessageBox.Show("Mời bạn trở lại trang chủ!!!", "Thông báo trở về", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                {
                    Home a = new Home();
                    a.Show();
                    Close();
                }
            }

        }
            
    }
}
