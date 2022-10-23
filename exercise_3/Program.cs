double number()
{
    while(true)
    {
        Console.WriteLine("Введите число: ");
        string number = Console.ReadLine();
        if(double.TryParse(number, out double numberint))
        {
            return numberint;
        }
    Console.WriteLine("Некорректный ввод!");

    }
    
}
double numberint = number();
double [] cube = new double[Convert.ToInt32(numberint)];
int i = 1;

while(numberint > 0)
{
    cube[i-1] = Math.Pow(i,3);
    numberint = numberint - 1;
    i++;    
}
Console.Write(string.Join(",",cube));