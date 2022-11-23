/* Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
  которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int [,] array()  //создаем пустой массив
{
    int m = new Random().Next(3,5);
    int n = new Random().Next(3,5);
    int [,] array = new int[m,n];
    return array; 
}

int [,] arraynew = array();

int [,] outputarray(int [,] arr) // заполяем и выводим массив
{
    for (int i = 0; i < arr.GetLength(0);i++)
    {
        for ( int j = 0; j < arr.GetUpperBound(1)+1; j++)
        {
            arr[i,j] = new Random().Next(0,10);
            Console.Write($"{arr[i,j]}\t");
        }
    Console.WriteLine();
    
    }
    return arr;

}
int [,] arrnew = outputarray(arraynew);

int summcount(int [,] arr,int minsumm = 0,int i = 0, int summ=0,int count = 0) // Определяем строку с наименьшей суммой элементов
{
    if (i < arr.GetLength(0))
    { 
        for(int j = 0; j < arr.GetUpperBound(1)+1; j++)
        {
            summ = summ + arr[i,j];
        }
        if(summ < minsumm){ minsumm = summ; count = i+1;}
        if (i == 0) {minsumm = summ; count = i+1;}
        i++;
        
        return summcount(arrnew,minsumm,i,summ = 0,count);

    }
    return count;
}
Console.WriteLine($"Cтрока с наименьшей суммой элементов :  {summcount(arrnew)}");



