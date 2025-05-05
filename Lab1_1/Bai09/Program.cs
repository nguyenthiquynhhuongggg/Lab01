Console.Write("Nhập n: ");
int n = int.Parse(Console.ReadLine());
long gt = 1;
for (int i = 2; i <= n; i++) gt *= i;
Console.WriteLine($"{n}! = {gt}");