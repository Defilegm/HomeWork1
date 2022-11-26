/* Задача 3: Напишите программу вычисления
 функции Аккермана с помощью рекурсии. 
 Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
int AckermannF(int m, int n)
{
    if(m == 0) return n + 1;
    if( m > 0 && n == 0) return AckermannF(m-1,1);
    if(m > 0 && n > 0) return AckermannF(m-1,AckermannF(m, n-1));
    return n;
}

Console.WriteLine(AckermannF(3,5));