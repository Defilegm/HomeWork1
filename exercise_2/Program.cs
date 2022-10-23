double[] coordinates()
{
    while(true)
    {
        string x = Console.ReadLine();
        string y = Console.ReadLine();
        string z = Console.ReadLine();
        if(double.TryParse(x, out double x1) && double.TryParse(y, out double y1) && double.TryParse(z, out double z1))

        {
             double[] newTuple = {Convert.ToDouble(x),Convert.ToDouble(y),Convert.ToDouble(z)};
             return newTuple;
        }
    Console.WriteLine("Некорректный ввод!");   
    Console.WriteLine("Повторите ввод: ");    
    
    }
}
Console.WriteLine("Введите координаты первой точки:");
double[] coordinates1 = coordinates();
Console.WriteLine("Введите координаты второй точки:");
double[] coordinates2 = coordinates();

Console.WriteLine($"Расстояние между точками : {Math.Round(Math.Sqrt(Math.Pow((coordinates2[0] - coordinates1[0]),2)+Math.Pow((coordinates2[1] - coordinates1[1]),2)+Math.Pow((coordinates2[2] - coordinates1[2]),2)),2)}");


