Console.Write("Nhập vào một số:");
int x = int.Parse(Console.ReadLine());
if(x > 0){
    System.Console.Write($"{x} là số dương!");
} else if(x == 0){
    System.Console.WriteLine($"{x} là số không!");
} else{
    System.Console.WriteLine($"{x} là số âm!");
}