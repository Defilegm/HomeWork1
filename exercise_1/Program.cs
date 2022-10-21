int check()
{
    while(true)
    {

        Console.WriteLine("Введите трехзначное число: ");
        string x = Console.ReadLine();
        if(int.TryParse(x,out int a))
        {   
            if (a >= 100 && a < 1000)
            {
                return a;
            }
        }
        Console.WriteLine("Некорректный ввод!");
    }
}
int b = check(); 
Console.WriteLine($"Вторая цифра: {b / 10 % 10}");