namespace Bai01
{
    internal class PhanSo{
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo(int tuSo, int mauSo){
            TuSo = tuSo;
            MauSo = (mauSo != 0) ? mauSo : 1;
        }

        public PhanSo(){
            TuSo = 0;
            MauSo = 1;
        }

        public void Nhap(){
            Console.Write("\tTử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("\tMẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
            if (MauSo == 0){
                Console.WriteLine("Mẫu số phải khác 0! Mặc định = 1.");
                MauSo = 1;
            }
        }

        public static PhanSo RutGon(PhanSo ps){
            int ucln = UCLN(Math.Abs(ps.TuSo), Math.Abs(ps.MauSo));
            return new PhanSo(ps.TuSo / ucln, ps.MauSo / ucln);
        }

        public static int UCLN(int a, int b){
            while (b != 0){
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        public static PhanSo Cong(PhanSo a, PhanSo b){
            int tsNew = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            int msNew = a.MauSo * b.MauSo;
            return RutGon(new PhanSo(tsNew, msNew));
        }

        public void HienThi(){Console.WriteLine($"{TuSo}/{MauSo}");}
    }
}