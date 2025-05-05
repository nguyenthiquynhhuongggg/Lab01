internal class Bai02
{
    private static void Main(string[] args)
    {
        Console.Write("Nhập vào chiều dài: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập vào chiều rộng: ");
        double b = double.Parse(Console.ReadLine());
        double s = a * b;
        Console.WriteLine($"Diện tích của hình chữ nhật = {s}");
    }
}