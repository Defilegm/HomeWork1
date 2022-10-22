int check()
{
    while(true)
    {
        Console.WriteLine("Введите число: ");
        string number = Console.ReadLine();
        if(int.TryParse(number, out int numberint))
        {
            return numberint;
            
        }
    Console.WriteLine("Некорректный ввод!");
    }
}
int number = check();  

int numberdouble = 0;
if (number / 100 > 0)
{
    while (number / 100 > 0)
    {
    numberdouble = number;
    number = number / 10;
    

    }
Console.WriteLine($"Третья цифра заданного числа: {numberdouble%10}");
}
else
{
    Console.WriteLine("В заданном числе нет третьей цифры!");
}





