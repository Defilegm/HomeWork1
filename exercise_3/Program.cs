/* Задача 3: Задайте две матрицы. Напишите программу, 
   которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4        
3 2 | 3 3  
Результирующая матрица будет:
18 20
15 18

*/



int [,] createarray(int m,int n) // создаем пустой массив
{
    int [,] array = new int [m,n];
    return array;
} 

 int [,] fillarray (int [,] arr)   // заполняем массив
 {
    for(int i = 0; i<arr.GetLength(0);i++)
    {
        for(int j = 0; j<arr.GetUpperBound(1)+1;j++)
        {
            arr[i,j]=new Random().Next(1,5);
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return arr;
 }

Console.WriteLine("Первый массив: ");
int [,] arrfisrt = fillarray(createarray(2,3));
Console.WriteLine("Второй массив: ");
int [,] arrsecond = fillarray(createarray(3,2));


int [,] multiplyarrays(int [,] arr1, int[,] arr2)  // перемножаем массивы
{
    if(arr1.GetUpperBound(1)+1 == arr2.GetLength(0)) // Проверка кол-ва столбцов 1ого массива с кол-вом строк 2ого массива
    {
        Console.WriteLine("Третий массив: ");
        int [,] arr3 = new int [arr1.GetLength(0),arr2.GetUpperBound(1)+1];
        int summ = 0;
        int f = 0;
            for (int i = 0; i<arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetUpperBound(1)+1; j ++)
                {
                    while( f < arr2.GetLength(0))
                    {
                        summ = summ + arr1[i,f]*arr2[f,j];
                        f++;
                    }
                    arr3[i,j] = summ;
                    f = 0;
                    summ = 0;
                    Console.Write($"{arr3[i,j]}\t");
                }
                Console.WriteLine();
            }
            
            return arr3;
        } 
    Console.WriteLine("ERROR :Кол-во столбцов первой матрицы, должны быть равны кол-ву строк второй матрицы!");
    return arr1;
    
}
multiplyarrays(arrfisrt,arrsecond);