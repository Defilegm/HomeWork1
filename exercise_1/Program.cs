Console.Write("Введите  первое число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double c = Convert.ToDouble(Console.ReadLine());
if (b>c)
{
    Console.WriteLine($"Число {b} больше чем {c}");
}
else if(c>b)
{
    Console.WriteLine($"Число {c} больше чем {b}");
}
else if( b == c)
{
    Console.WriteLine($"Числа  равны");
}