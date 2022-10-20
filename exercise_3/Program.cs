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
if (a % 2 == 0)
{
    Console.WriteLine($"Число {a} является четным");
}
else
{
    Console.WriteLine($"Число {a} не является четным");
}