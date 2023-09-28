using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemNet.DAO
{
    public class Table
    {
        private int iD;
        private string name;
        private string status;

        public Table(int iD, string name, string status)
        {
            this.iD = iD;
            this.name = name;
            this.status = status;
        }
        public Table(DataRow row)
        {
            ID = (int)row["iD"];
            Name = (string)row["name"];
            Status = (string)row["status"]; 
        }
        public Table() { }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }

    }
}
