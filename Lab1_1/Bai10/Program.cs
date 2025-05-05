Console.Write("Nhập một số nguyên: ");
int n = int.Parse(Console.ReadLine());
if (n < 2){
    Console.WriteLine($"{n} không phải là số nguyên tố!");
} else{
    int i = 2;
    while (i <= Math.Sqrt(n)){
        if (n % i == 0){
            Console.WriteLine($"{n} không phải là số nguyên tố!");
            return; 
        }
        i++;
    }
    Console.WriteLine($"{n} là số nguyên tố!");
}