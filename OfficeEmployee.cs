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

        public string Ten { get { return ten; } set { ten = value; } }
        public double LuongCoBan { get { return luongCoBan; } set { luongCoBan = value; } }
        public double HeSoLuong { get { return heSoLuong; } set { heSoLuong = value; } }
        public double PhuCap { get { return phuCap; } set { phuCap = value; } }
        public int SoGioNgoaiHanhChinh { get { return soGioNgoaiHanhChinh; } set { soGioNgoaiHanhChinh = value; } }

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
            if (luong > 10000000  & luong <= 20000000)
            {
                thue = (luong - 10000000) * 0.1;
            }
            else
            {
                thue = (20000000 - 10000000) * 0.1 + (luong - 20000000) * 0.15;
            }
            return thue;
        }

        

        public string Print(int i)
        {
            return $"{i}. {ten}, Lương: {Math.Round(TinhLuong(), 2)}, Thưởng: {Math.Round(TinhThuong(), 2)},Thuế: {Math.Round(TinhThue(), 2)}";
        }
    }
}
