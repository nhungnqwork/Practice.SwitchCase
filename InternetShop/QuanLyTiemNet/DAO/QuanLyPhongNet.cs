using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemNet
{
    internal class QuanLyPhongNet
    {
        private string _name;
        private string _status;

        public QuanLyPhongNet() { }

        public QuanLyPhongNet(string name, string status)
        {
            _name = name;
            _status = status;
        }

        public string Name { get => _name; set => _name = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
