int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int s = 0;  
foreach (int i in arr){
    if (i % 2 == 0){
        s += i;  
    }
}
Console.WriteLine($"Tổng các số chẵn trong mảng = {s}");