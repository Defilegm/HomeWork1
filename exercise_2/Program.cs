int[] array()
{
    Random rnd = new Random();
    int [] array = new int [rnd.Next(1,10)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}
int[] array1 = array();

int checkpos()
{
    int summ  = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (i % 2 != 0){summ = summ + array1[i];}
    }
    return summ;
}
Console.WriteLine(string.Join(" ", array1));
Console.Write($"Сумма элементов, стоящие на нечетных позициях: {checkpos()}");