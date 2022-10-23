int check()
{
    while(true)
    {

        Console.WriteLine("Введите пятизначное число: ");
        string x = Console.ReadLine();
        if(int.TryParse(x,out int a))
        {   
            if (a >= 10000 && a < 100000)
            {
                return a;
            }
        }
        Console.WriteLine("Некорректный ввод!");
    }
}
int b = check();

if (b % 10 == b / 10000 && (b % 100) / 10 == (b / 1000) % 10)
{
    Console.WriteLine($"Число:{b} является палиндромом");

}
else
{
    Console.WriteLine($"Число:{b} не является палиндромом");
}