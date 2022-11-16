
/* Задача 3. (*) Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами) */

int [,] array() // cоздаем массив
{
    int n = new Random().Next(1,6);
    int [,] array = new int [n,n];
    return array;
}


int [,] printarray (int [,] array) //заполняем  и выводим массив
{
    int rows = array.GetUpperBound(0)+1;
    int columns = array.Length / rows;
    for(int i=0; i<rows; i++)
    {
        for (int j=0; j<columns;j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write($"{array[i,j]}\t");
        
        }
    Console.WriteLine();
    
    
    }
    return array;
}

int [,] newarray = printarray(array());

int maxinrows( int [,] arrays,int max = 0,int summ = 0,int i = 0) // Находим сумму максимальных элементов с строках
{
    while(i < arrays.GetUpperBound(0)+1)
    {
        max = arrays[i,0];
        for(int j = 0 ; j<arrays.Length/(arrays.GetUpperBound(0)+1);j++)
        {
            if(arrays[i,j] > max) max = arrays[i,j];
        }
        summ = summ + max;
        i++;
        return maxinrows( newarray,max,summ,i);
    }
    return summ;

}
Console.WriteLine($"сумма максимумов в строках = {maxinrows(newarray)}");

int minincol( int [,] arrays,int min = 0,int summ = 0,int i = 0)// Находим сумму мин элементов с столбцах
{
    while(i < arrays.Length/(arrays.GetUpperBound(0)+1))
    {
        min = arrays[0,i];
        for(int j = 0 ; j<arrays.GetUpperBound(0)+1;j++)
        {
            if(arrays[j,i] < min) min = arrays[j,i];
        }
        summ = summ + min;
        i++;
        return minincol(newarray,min,summ,i);
    }
    return summ;

}

Console.WriteLine($"сумма минимумов в столбцах = {minincol(newarray)}");
Console.WriteLine($"разность макс строк и мин столбцов = {maxinrows(newarray) - minincol(newarray)}");


