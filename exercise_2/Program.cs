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
void summ()
{
    int result = check(Console.ReadLine());
    int result1 = result;
    int summ = 0;
    while(result > 0)
    {
        summ = summ + result % 10;
        result = result / 10;
    }
    Console.WriteLine($"Сумма цифр в числе {result1} равен {summ} ");
}
summ();