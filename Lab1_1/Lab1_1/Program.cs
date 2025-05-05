using System;
using System.Text;
namespace LAB1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Config Console Output được Tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            //1. Khai báo biến
            int x1, x2, y1, y2;
            //2. Nhập giá trị
            Console.WriteLine("Nhập điểm A(x1, y1):");
            Console.Write("- x1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("- y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm B(x2, y2):");
            Console.Write("- x2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("- y2: ");
            y2 = int.Parse(Console.ReadLine());
            //3. Tính khoảng cách
            double khoangCach = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //4. Hiển thị kết quả
            Console.WriteLine($"Khoảng cách giữa điểm A({x1}, {y1}) với điểm B({x2}, {y2}) = {khoangCach}");
        }
    }   
}