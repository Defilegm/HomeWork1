/* Задача 1: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


int [,] array()   // cоздаем пустой массив
{
    int m = new Random().Next(1,6);
    int n = new Random().Next(1,6);
    int [,] array = new int [m,n];
    return array;
}
int [,] newarray = array();

int [,] printarray(int [,] arr) // заполняем и выводим массив;
{
    for (int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetUpperBound(1)+1; j++)
        {
            arr[i,j] = new Random().Next(1,10);
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
    return arr;
}

int [,] newarr = printarray(newarray);

int [,] sortarray(int [,] arr) //сортируем  массив
{
    int current = 0;
    for (int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetUpperBound(1)+1; j++)
        {
            int a = j;
            while(a > 0)
            {
                if (arr[i,a] > arr[i,a-1]){ current = arr[i,a-1]; arr[i,a-1] = arr[i,a]; arr[i,a] = current; a = a - 1;}
                else{ break;}
            }
        }
    }
    return arr;
}
Console.WriteLine();
sortarray(newarr);
Console.WriteLine();

int [,] printarrays(int [,] arr) // выводим отсортированный массив;
{
    for (int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetUpperBound(1)+1; j++)
        {
    
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
    return arr;
}
printarrays(newarr);