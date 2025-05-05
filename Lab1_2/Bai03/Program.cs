Console.Write("Nhập số phần tử: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int soA = 0, soD = 0;
for (int i = 0; i < n; i++){
    Console.Write($"arr[{i}] = ");
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i] > 0) soD++;
        else if (arr[i] < 0) soA++;
}
Console.WriteLine($"\nSố lượng số dương: {soD}");
Console.WriteLine($"Số lượng số âm: {soA}");