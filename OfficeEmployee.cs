using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_B4_OOP
{
    public class OfficeEmployee : IEmployee
    {
        private string ten;
        private double luongCoBan;
        private double heSoLuong;
        private double phuCap;
        private int soGioNgoaiHanhChinh;

        public OfficeEmployee(string ten, double luongCoBan, double heSoLuong, double phuCap, int soGioNgoaiHanhChinh)
        {
            this.ten = ten;
            this.luongCoBan = luongCoBan;
            this.heSoLuong = heSoLuong;
            this.phuCap = phuCap;
            this.soGioNgoaiHanhChinh = soGioNgoaiHanhChinh;
        }
        public double TinhLuong()
        {
            return luongCoBan * (heSoLuong + phuCap);
        }

        public double TinhThuong()
        {
            return soGioNgoaiHanhChinh * 100000;
        }

        public double TinhThue()
        {
            double luong = TinhLuong();
            double thue = 0;
            if (luong > 10000000)
            {
                if (luong <= 20000000)
                {
                    // Đóng thuế 10% cho phần vượt 10 triệu
                    thue = (luong - 10000000) * 0.1;
                }
                else
                {
                    // Đóng thuế 10% cho phần từ 10-20 triệu và 15% cho phần vượt 20 triệu
                    thue = (20000000 - 10000000) * 0.1 + (luong - 20000000) * 0.15;
                }
            }
            return thue;
        }

        public string Print()
        {
            return $"Tên: {ten}, Lương: {TinhLuong()}, Thưởng: {TinhThuong()}, Thuế: {TinhThue()}";
        }

    }
}
