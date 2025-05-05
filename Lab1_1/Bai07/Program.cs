Console.Write("Nhập vào một năm: ");
int nam = int.Parse(Console.ReadLine());
if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0)){
    Console.WriteLine($"{nam} là năm nhuận!");
} else{
    Console.WriteLine($"{nam} không phải là năm nhuận!");
}