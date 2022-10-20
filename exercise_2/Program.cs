Console.WriteLine($"Введите 1-е число");
double a = Convert.ToDouble(Console.ReadLine());
double max = a;
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Введите {i+2}-е число");
    double b = Convert.ToDouble(Console.ReadLine());
    if (b > max)
    {
        max = b;
    }
}
Console.WriteLine($"Максимальное число = {max}");