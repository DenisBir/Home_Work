

Console.Write("Введите любой номер для проверки на ПАЛИНДРОМ : ");
int number = int.Parse(Console.ReadLine()!);
int remineder, sum = 0;
int temp = number;
    while (number > 0)
    {
    remineder = number % 10;

    sum = (sum * 10) + remineder;

    number = number / 10; 
    }
        if (temp == sum)
        {
            Console.WriteLine($"Число {temp} ПАЛИНДРОМ");
        }
        else
        {
            Console.WriteLine($"Число {temp} не ПАЛИНДРОМ");
        }
    