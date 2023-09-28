using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemNet
{
    internal class QuanLyHoaDon
    {
        private int _id;
        private string _userName;
        private string _type;
        private string _amount;
        private string _date;
        private string _checked;

        public QuanLyHoaDon(int id, string userName, string type, string amount, string date, string @checked)
        {
            _id = id;
            _userName = userName;
            _type = type;
            _amount = amount;
            _date = date;
            _checked = @checked;
        }

        public int Id { get => _id; set => _id = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Type { get => _type; set => _type = value; }
        public string Amount { get => _amount; set => _amount = value; }
        public string Date { get => _date; set => _date = value; }
        public string Checked { get => _checked; set => _checked = value; }
    }
}
