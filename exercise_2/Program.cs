string checknum()
{
    while(true)
    {
        string text = Console.ReadLine();
        if (double.TryParse(text, out double number))         // функция проверки ввода пользователем
        {
            return text;
            break;
        }
Console.WriteLine("Некорректный ввод, введите ЧИСЛО!");
}
   
}

Console.WriteLine($"Введите 1-е число");
double a = Convert.ToDouble(checknum());
double max = a;
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Введите {i+2}-е число");
    double b = Convert.ToDouble(checknum());
    if (b > max)
    {
        max = b;
    }
}
Console.WriteLine($"Максимальное число = {max}");
