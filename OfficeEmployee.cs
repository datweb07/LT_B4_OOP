using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_B4_OOP
{
    public class OfficeEmployee : IEmployee
    {
        public double TinhLuong(double luongCoBan, double heSoLuong, double phuCap)
        {
            double luong = luongCoBan * (heSoLuong + phuCap);
            return luong;
        }

        public double TinhThuong(double startTime, double endTime)
        {
            return (endTime - startTime) * 100;
        }

        public void TinhThue()
        {
            throw new NotImplementedException();
        }
    }
}
