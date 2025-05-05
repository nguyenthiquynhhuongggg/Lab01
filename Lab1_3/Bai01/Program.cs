using System.Collections;
using System.Text;
using Bai01;

internal class Program
{
    public static void searchName(List<CanBo> l, string name)
    {foreach (CanBo c in l){if (c.HoTen.Equals(name)){c.xuat();}}}

    private static void Main(string[] args){
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        List<CanBo> dsCB = new List<CanBo>();
        int select;
        while (true){
            try{
                Console.WriteLine("Quản lí cán bộ");
                Console.WriteLine("1. Thêm nhân viên.");
                Console.WriteLine("2. Thêm kỹ sư.");
                Console.WriteLine("3. Thêm công nhân.");
                Console.WriteLine("4. Xem danh sách cán bộ.");
                Console.WriteLine("5. Tìm kiếm cán bộ theo tên.");
                Console.WriteLine("0. Thoát chương trình.");
                Console.Write("- Nhập lựa chọn: ");
                select = int.Parse(Console.ReadLine());
                if (select == 0) break;
                switch (select){
                    case 1:{
                            NhanVien nhanVien = new NhanVien();
                            Console.WriteLine("Nhập thông tin cho nhân viên mới: ");
                            nhanVien.nhap();
                            dsCB.Add(nhanVien);
                            Console.WriteLine("Đã thêm nhân viên vào danh sách.");
                            Console.WriteLine("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            KySu kySu = new KySu();
                            Console.WriteLine("Nhập thông tin kỹ sư mới: ");
                            kySu.nhap();
                            dsCB.Add(kySu);
                            Console.WriteLine("Thêm kỹ sư thành công!");
                            Console.WriteLine("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 3:{
                            CongNhan congNhan = new CongNhan();
                            Console.WriteLine("Nhập thông tin cho công nhân mới: ");
                            congNhan.nhap();
                            dsCB.Add(congNhan);
                            Console.WriteLine("Thêm công nhân thành công!");
                            Console.WriteLine("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 4:{
                            foreach(var cb in dsCB){
                                if (cb is NhanVien){
                                    NhanVien nhanVien = (NhanVien) cb;
                                    nhanVien.xuat();
                                }
                                else if (cb is CongNhan){
                                    CongNhan congNhan = (CongNhan) cb;
                                    congNhan.xuat();
                                }
                                else if (cb is KySu){
                                    KySu kySu = (KySu) cb;
                                    kySu.xuat();
                                }
                            }
                            Console.WriteLine("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    case 5:{
                            string name;
                            Console.Write("Nhập tên muốn tìm kiếm: ");
                            name = Console.ReadLine();
                            searchName(dsCB, name);
                            Console.WriteLine("Nhấn nút bất kì để tiếp tục.");
                            Console.ReadKey();
                            break;
                        }
                    default: break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nhập không hợp lệ vui lòng nhập lại.");
            }
        }
    }
}