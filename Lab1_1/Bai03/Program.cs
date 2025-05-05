internal class Bai03
{
    private static void Main(string[] args)
    {
        System.Console.Write("Nhập vào độ C: ");
        double doC = double.Parse(Console.ReadLine());
        double doF = (doC * 9/5) + 32;
        System.Console.WriteLine($"{doC} độ C = {doF} độ F");
    }
}