using System;
namespace LAB2
{
    class Program
    {
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public static int TinhTong(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            return tong;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo biến n
            int n;
            //Nhập giá trị cho biến n
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            //Khai báo và khởi tạo mảng số nguyên có n phần tử
            int[] a = new int[n];
            //Gọi hàm nhập mảng
            NhapMang(a, n);
            //Gọi hàm Tính Tổng các phần tử trong mảng và hiển thị kết quả ra màn hình
            Console.WriteLine($"Tổng = {TinhTong(a,n)}");
        }
    }
}