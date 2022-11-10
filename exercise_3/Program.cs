double[] array()
{
    Random rnd = new Random();
    double [] array = new double [rnd.Next(1,10)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}
double[] array1 = array();

double diff()
{
    double max = array1[0];
    double min = array1[0];
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > max){max = array1[i];}
        if (array1[i] < min){min = array1[i];}
    }
    double result = max - min;
    return result;
}
Console.WriteLine(string.Join(" ", array1));
Console.Write($"Разница между max и min: {diff()}");