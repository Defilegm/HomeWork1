int checknum()
{
    while(true)
    {
        Console.WriteLine("Введите цифру от 1 до 7: ");
        string number = Console.ReadLine();
        if (int.TryParse(number, out int numbint))
        {
            if(numbint < 8 && numbint > 0)
            {
                return numbint;
            }
        }
    Console.WriteLine("Некорректный ввод!");
    } 
}
int dayoff = checknum();
if (dayoff == 6 || dayoff == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Невыходной день");
}