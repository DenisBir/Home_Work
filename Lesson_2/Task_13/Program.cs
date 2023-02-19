 
Console.Clear();
Console.Write("Введите любое число: ");
int a = Int32.Parse((Console.ReadLine())!);
if(a <= 99){
    Console.WriteLine("Число меньше 100");
    }else{
        while(a>1000){
            a/=10; //a=a/10
    }
    Console.WriteLine(a%10);
}
/*
    Index index1 = 2;
   
    Console.WriteLine($"{num} {index1}");


Console.WriteLine("Введите любое число: ");
    int IndexOf(int [] array, int value)
    Index index2 = 2;
    Console.WriteLine(numbers[index2]);
*/