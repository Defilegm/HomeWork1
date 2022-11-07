int check(string x)
{
    while(true)
    { 
        if (int.TryParse(x, out int result))
        {
        return result;
        }
        Console.WriteLine("Введите целое число!");
        x = Console.ReadLine();
    }
    
}

void expo()
{
    Console.WriteLine("Введите первое число");
    int a = check(Console.ReadLine());
    Console.WriteLine("Введите второе число число");
    int b = check(Console.ReadLine());
    int result = a;
    while (b > 1)
    {
        result =  result * a;
        b = b - 1;
    }
    Console.WriteLine(result);
}
expo();
