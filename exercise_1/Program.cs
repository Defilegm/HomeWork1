/* Задача 1. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9
 
8 7,8 -7,1 9   */



double random()   //создаем генератор случайных вещественных чисел
{
    double rnd =  new Random().Next(0,1000);
    rnd = rnd / 10;
    return rnd;
}

double [,] array(int m,int n)  // cоздаем массив и заполняем его
{
    double [,] array = new double[m,n];
    for (int i = 0; i< m; i ++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i,j] = random();
        }
    }
    return array;
}




double [,] printarray(double [,] array)
{
    for(int i = 0; i< array.Length / (array.GetUpperBound(1)+1); i++)
    {
        for (int j = 0; j<(array.GetUpperBound(1)+1); j++)
        {  
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
    return array;
}
printarray(array(5,6));

