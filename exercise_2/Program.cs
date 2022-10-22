Random rnd = new Random();
int number = rnd.Next(100,1000);
Console.WriteLine($"Случайное число: {number}");
int newnumber = number / 100;
int newnumber2 = number % 10;
Console.WriteLine($"Удаление второй цифры...: {newnumber}"+newnumber2) ;
