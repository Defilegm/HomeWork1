/* Задача 2. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */
int [,] array()
{
    int m = new Random().Next(0,10);
    int n = new Random().Next(1,10);
    int [,] array = new int[m,n];
    return array; 
}
int [,] arraynew = array();

int [,] outputarray(int [,] arr)
{
    for (int i = 0; i < arr.Length / (arr.GetUpperBound(1)+1);i++)
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
outputarray(arraynew);

int input(int i, int j, int [,] arr)
{
    if(i >= arr.Length / (arr.GetUpperBound(1)+1) || j>= arr.GetUpperBound(1)+1){Console.WriteLine("Элемента с такой позицией не существует!"); }
    else {Console.WriteLine($"Элементс позицией {i},{j} = {arr[i,j]}");}
    return i;
}
input(6,6,arraynew);



