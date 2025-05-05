using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal abstract class CanBo
    {
        public string HoTen{get; set;}
        public byte gt{get; set;}
        public int NamSinh{get; set;}
        public string dChi{get; set;}
        public CanBo(){}

        public CanBo(string hoTen, byte gt, int namSinh, string dChi){
            this.HoTen = hoTen;
            this.gt = gt;
            this.NamSinh = namSinh;
            this.dChi = dChi;
        }

        public void nhap(){
            try{
                Console.Write("Nhập họ tên: ");
                HoTen = Console.ReadLine();
                Console.Write("Nhập giới tính: ");
                gt = Byte.Parse(Console.ReadLine());
                Console.Write("Nhập năm sinh: ");
                NamSinh = int.Parse(Console.ReadLine());
                if (NamSinh <= 0) throw new Exception();
                Console.Write("Nhập địa chỉ: ");
                dChi = Console.ReadLine();
            }
            catch (Exception)
            {throw;}
        }
        public void xuat(){
            Console.WriteLine($"Họ và tên: {HoTen}.");
            string gender = gt == 1 ? "Nam" : "Nữ";
            Console.WriteLine($"Giới Tính: {gender}.");
            Console.WriteLine($"Năm sinh: {NamSinh}.");
            Console.WriteLine($"Địa chỉ: {dChi}.");
        }
    }
}