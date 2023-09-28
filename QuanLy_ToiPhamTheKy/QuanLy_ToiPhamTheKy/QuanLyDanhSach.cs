using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_ToiPhamTheKy
{
    internal class QuanLyDanhSach
    {
        private string _id;
        private string _hoTen;
        private string _ngayThang;  
        private string _nguyenNhan;
        public QuanLyDanhSach() { }
        public QuanLyDanhSach(string id, string hoTen, string ngayThang, string nguyenNhan)
        {
            _id = id;
            _hoTen = hoTen;
            _ngayThang = ngayThang;
            _nguyenNhan = nguyenNhan;
        }

        public string Id { get => _id; set => _id = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string NgayThang { get => _ngayThang; set => _ngayThang = value; }
        public string NguyenNhan { get => _nguyenNhan; set => _nguyenNhan = value; }
    }
}
