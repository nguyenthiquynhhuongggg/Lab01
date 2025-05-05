Console.Write("Nhập vào số thứ nhất: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Nhập vào số thứ hai: ");
double b = double.Parse(Console.ReadLine());
double s = a * b;
double t = a + b;
Console.WriteLine($"Tổng của hai số {a} và {b} = {t}");
Console.WriteLine($"Tích của hai số {a} và {b} = {s}");