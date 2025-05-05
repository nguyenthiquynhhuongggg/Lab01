Console.Write("Nhập số phần tử: ");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++){
    Console.Write($"a[{i}] = ");
    a[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\nCác số nguyên tố trong mảng:");
for (int i = 0; i < n; i++){
    int x = a[i];
    if (x < 2) continue;
    bool nt = true;
    for (int j = 2; j <= Math.Sqrt(x); j++)
        if (x % j == 0) { nt = false; break; }
    if (nt) Console.WriteLine($"Chỉ số: {i}, Giá trị: {x}");
}