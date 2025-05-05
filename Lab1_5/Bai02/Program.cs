using System.Diagnostics.Metrics;
using System.Text;
using Bai02;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<Hinh> hinh = new List<Hinh>();
        int select;
        while (true){
            try{
                Console.WriteLine("1. Thêm hình tam giác.");
                Console.WriteLine("2. Thêm hình tròn.");
                Console.WriteLine("3. Thêm hình vuông.");
                Console.WriteLine("4. Thêm hình chữ nhật.");
                Console.WriteLine("5. Tổng chu vi và diện tích các hình.");
                Console.WriteLine("0. Thoát chương trình.");
                Console.Write("- Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                if (select == 0) return;

                switch(select){
                    case 1:{
                            double[] x = {0, 0, 0};
                            for(int i = 0; i < 3; i++){
                                Console.Write($"Nhập cạnh thứ {i + 1}: ");
                                x[i] = double.Parse(Console.ReadLine());
                            }
                            HinhTamGiac hinhTamGiac = new HinhTamGiac(x[0], x[1], x[2]);
                            hinh.Add(hinhTamGiac);
                            Console.WriteLine("Thêm hình thành công!");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 2:{
                            double r;
                            Console.Write("Nhập bán kình hình tròn: ");
                            r = double.Parse(Console.ReadLine());
                            HinhTron hinhTron = new HinhTron(r);
                            hinh.Add(hinhTron);
                            Console.WriteLine("Thêm hình thành công!");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 3:{
                            double y;
                            Console.Write("Nhập độ dài cạnh: ");
                            y = double.Parse(Console.ReadLine());
                            HinhVuong hinhVuong = new HinhVuong(y);
                            hinh.Add(hinhVuong);
                            Console.WriteLine("Thêm hình thành công!");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 4:{
                            double a, b;
                            Console.Write("Nhập chiều dài: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Nhập chiều rộng: ");
                            b = double.Parse(Console.ReadLine());
                            HinhChuNhat hinhChuNhat = new HinhChuNhat(a, b);
                            hinh.Add(hinhChuNhat);
                            Console.WriteLine("Thêm hình thành công!");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 5:{
                            double tongCV = 0, tongDT = 0;
                            foreach(Hinh h in hinh){
                                if(h is HinhChuNhat){
                                    HinhChuNhat H = (HinhChuNhat)h;
                                    double a = H.ChuVi(), b = H.DienTich();
                                    tongCV += a;
                                    tongDT += b;
                                    Console.WriteLine($"Hình chữ nhật ({H.Dai} - {H.Rong}) - C: {a} - S: {b}.");
                                }
                                else if(h is HinhTamGiac){
                                    HinhTamGiac H = (HinhTamGiac)h;
                                    double a = H.ChuVi(), b = H.DienTich();
                                    tongCV += a;
                                    tongDT += b;
                                    Console.WriteLine($"Hình tam giác ({H.A} - {H.B}) - {H.C} - C: {a} - S: {b}.");
                                }
                                else if(h is HinhTron){
                                    HinhTron H = (HinhTron)h;
                                    double a = H.ChuVi(), b = H.DienTich();
                                    tongCV += a;
                                    tongDT += b;
                                    Console.WriteLine($"Hình tròn ({H.r}) - C: {a} - S: {b}.");
                                }
                                else if(h is HinhVuong){
                                    HinhVuong H = (HinhVuong)h;
                                    double a = H.ChuVi(), b = H.DienTich();
                                    tongCV += a;
                                    tongDT += b;
                                    Console.WriteLine($"Hình vuông ({H.Canh}) - C: {a} - S: {b}.");
                                }
                            }
                            Console.WriteLine($"Tổng chu vi = {tongCV} - Tổng diện tích = {tongDT}");
                            Console.Write("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    default: continue;
                }
            }
            catch (Exception){continue;}
        }
    }
}