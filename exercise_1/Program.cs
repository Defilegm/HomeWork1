/* Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

int numbers(int m, int n)
{
    if(n < 0) {Console.WriteLine("В этом интервале нет натуральных чисел"); return 0;}
    if(m > 0 && m % 2 == 0 && m <= n) {Console.Write($"{m} ");return numbers(m+2,n);}
    if(m < 0 && m % 2 == 0) return numbers(m+2,n);
    if(m < 0 && m % 2 != 0) return numbers(m+1,n);
    if(m > 0 && m != 0 && m<= n){Console.Write($"{m+1} ");return numbers(m+1,n);}
    if(m==0) return numbers(m+2,n);
    return m;

    
}

numbers(4,9);