using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemNet
{
    internal class QuanLyDoanhThu
    {
        private string _nhaMang;
        private int _chietKhau;
        private int _soLuong;
        private double _menhGia;
        private string _ngayThang;
        private string _userName;

        public QuanLyDoanhThu() { }

        public QuanLyDoanhThu(string nhaMang, int chietKhau, int soLuong, double menhGia, string ngayThang, string userName)
        {
            _nhaMang = nhaMang;
            _chietKhau = chietKhau;
            _soLuong = soLuong;
            _menhGia = menhGia;
            _ngayThang = ngayThang;
            _userName = userName;
        }

        public string NhaMang { get => _nhaMang; set => _nhaMang = value; }
        public int ChietKhau { get => _chietKhau; set => _chietKhau = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public double MenhGia { get => _menhGia; set => _menhGia = value; }
        public string NgayThang { get => _ngayThang; set => _ngayThang = value; }
        public string UserName { get => _userName; set => _userName = value; }

        public double TongTien() => (MenhGia * SoLuong * ChietKhau)/100;
    }
}
