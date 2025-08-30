using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_B4_OOP
{
    public class TempEmployee : IEmployee
    {
        private string ten;
        private int soNgayLam;
        private double donGia;
        private int soGioCanLam;

        public string Ten { get { return ten; } set { ten = value; } }
        public int SoNgayLam { get { return soNgayLam; } set {  soNgayLam = value; } }
        public double DonGia { get { return donGia; } set { donGia = value; } }
        public int SoGioCanLam { get { return soGioCanLam; } set { soGioCanLam = value; } }

        public TempEmployee(string ten, int soNgayLam, double donGia, int soGioCanLam)
        {
            this.ten = ten;
            this.soNgayLam = soNgayLam;
            this.donGia = donGia;
            this.soGioCanLam = soGioCanLam;
        }

        public double TinhLuong()
        {
            return soNgayLam * donGia;
        }

       

        public double TinhThue()
        {
            double luong = TinhLuong();
            double thue = 0;

            if (luong > 10000000)
            {
                thue = (luong - 10000000) * 0.15;
            }
            return thue;
        }

        public double TinhThuong()
        {
            double thuong = 0;
            if (soGioCanLam > 200)
            {
                thuong = (soGioCanLam - 200) * 50000;
            }
            return thuong;
        }

        public string Print(int i)
        {
            return $"{i}. {ten}, Lương: {Math.Round(TinhLuong(), 2)}, Thưởng: {Math.Round(TinhThuong(), 2)}, Thuế: {Math.Round(TinhThue(), 2)}";
        }

    }
}
