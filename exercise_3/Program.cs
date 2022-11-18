/* Задача 3. Задайте двумерный массив из целых чисел. 
             Найдите среднее арифметическое элементов в каждом столбце.

            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */




int [,] array () // создаем массив
{
    int m = new Random().Next(1,6);
    int n = new Random().Next(1,6);
    int [,] array = new int [m,n];
    return array;
}

int [,] outputarray(int[,]arr)   // заполняем и выводим массив
{
    for (int i = 0; i < arr.Length / (arr.GetUpperBound(1)+1);i++)
    {
        for(int j=0; j<arr.GetUpperBound(1)+1; j++)
        {
            arr[i,j] = new Random().Next(0,10);
            Console.Write($"{arr[i,j]}\t");
        }
    Console.WriteLine();
    }
    return arr;
}

int [,] newarray = outputarray(array());

double avg(int [,] arr) // находим среднее арифметиское каждого столбца
{
    int summ = 0;
    double avg = 0;
    for (int j = 0; j < (arr.GetUpperBound(1)+1);j++)
    {
        for ( int i = 0 ; i < arr.Length/(arr.GetUpperBound(1)+1);i++)
        {
            summ = summ + arr[i,j];
        }
        avg = (double)summ / (arr.Length / (arr.GetUpperBound(1)+1));
        Console.WriteLine($"Среднее арифметическое {j+1}-ого столбца = {avg}");
        avg = 0;
        summ = 0;
    }
    return avg;

}
avg(newarray);

