namespace LT_B4_OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
/*
Một interface IEmployee có các method sau: 
- Tính lương: tính lương của nhân viên
- Tính thưởng: tính khoảng tiền thưởng (trong tháng)
- Tính thuế: tính thuế tạm thu trong tháng
Một lớp OfficeEmployee thực thi interface IEmployee và triển khai các method của interface đó:
Lương = Lương cơ bản * (hệ số lương + phụ cấp ưu đãi), tính thưởng dựa trên số giờ làm ngoài giờ hành chính với mức thưởng cho mỗi giờ làm là 100k. Tính thuế: nếu lương > 10 triệu và < 20 triệu thì đóng thuế 10% với số dư vượt 10 triệu, 
từ mức trên 20 triệu đóng thuế 15% cho số dư vượt trên 20 triệu (phần nằm giữa 10 triệu và 20 triệu vẫn đóng thuế 10%)
Một lớp TempEmployee thực thi interface IEmployee: lương = số ngày thực làm * đơn giá, tính thưởng nếu số giờ cần làm vượt trên 200 giờ và thưởng 50.000 cho mỗi giờ vượt. Tính thuế, luôn áp dụng mức 15% với số tiền vượt 10 triệu
Trong hàm Main, tạo một mảng IEmployee để chứa đồng thời 2 nhóm đối tượng OfficeEmployee và TempEmployee (có thể random true false). Test thử các phương thức nói trên
 */