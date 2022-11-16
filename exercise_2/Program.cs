/* Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
             заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
             значения b1, k1, b2 и k2 задаются пользователем.
 */
double check(string x)
{
    while (true)
    {
        if (double.TryParse(x, out double result)) { return result; }
        Console.WriteLine("Некорректный ввод, введите число!");
        x = Console.ReadLine();
    }
} 

string f(double b1, double k1, double b2, double k2)
{
    double x=(b2-b1)/(k1-k2); 
    double y= k1*(b2-b1)/(k1-k2)+b1;
    string result = $"({x};{y})";
    return result;
}

Console.WriteLine("Введите B1: ");
double b1 = check(Console.ReadLine());
Console.WriteLine("Введите K1: ");
double k1 = check(Console.ReadLine());
Console.WriteLine("Введите B2: ");
double b2 = check(Console.ReadLine());
Console.WriteLine("Введите K2: ");
double k2 = check(Console.ReadLine());


Console.WriteLine(f(b1,k1,b2,k2));