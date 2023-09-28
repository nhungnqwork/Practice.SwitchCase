using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_ToiPhamTheKy
{
    public class Table
    {
        private int iD;
        private string maPhongGiam;
        private int soLuongPN;
        private string tinhTrang;

        public int ID { get => iD; set => iD = value; }
        public string MaPhongGiam { get => maPhongGiam; set => maPhongGiam = value; }
        public int SoLuongPN { get => soLuongPN; set => soLuongPN = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public Table(int iD, string maPhongGiam, int soLuongPN, string tinhTrang)
        {
            this.iD = iD;
            this.maPhongGiam = maPhongGiam;
            this.soLuongPN = soLuongPN;
            this.tinhTrang = tinhTrang;
        }
        public Table(DataRow row)
        {
            ID = (int)row["iD"];
            MaPhongGiam = (string)row["maPhongGiam"];
            SoLuongPN = (int)row["soLuongPN"];
            TinhTrang = (string)row["tinhTrang"];
        }
        public Table() { }

       
    }
}
