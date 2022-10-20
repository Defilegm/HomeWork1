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
Console.WriteLine("Введите число: ");
double a = Convert.ToDouble(checknum());
while(a != 0 )
{
    if(a > 0)
    {
        if(a % 2 == 0)
        {
            Console.Write($" {a}");
        }
        a = a - 1;
        
    }
    else if(a < 0)
    {
        if(a % 2 == 0)
        {
            Console.Write($" {a}");
        }
        a++;
    }
}