int[] array()
{
    Random rnd = new Random();
    int [] array = new int [rnd.Next(1,10)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int [] array1 = array();

int plusnumbers()
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i] % 2 == 0){ count ++;};
    }
    return count;
}
Console.WriteLine(string.Join(" ",array1));
Console.WriteLine($"Кол-во положительных элементов : {plusnumbers()}");

