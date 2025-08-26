using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_B4_OOP
{
    internal interface IEmployee
    {
        double TinhLuong(double luongCoBan, double heSoLuong, double phuCap);
        double TinhThuong(double startTime, double endTime);
        void TinhThue();
    }
}
