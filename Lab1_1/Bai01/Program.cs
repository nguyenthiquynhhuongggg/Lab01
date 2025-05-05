internal class Bai01
{
    private static void Main(string[] args)
    {
        System.Console.Write("Nhập vào tên: ");
        string ten = Console.ReadLine();
        System.Console.Write("Nhập vào tuổi: ");
        int tuoi = int.Parse(Console.ReadLine());
        System.Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
    }
}