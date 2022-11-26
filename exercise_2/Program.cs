/* Задача 2: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 */


int summ(int m, int n)
{
    if (n <= 1) return m;
    if(m < 1) return summ(m+1,n);
    return m + summ(m+1, n-1);
}

Console.WriteLine(summ(-10,15));