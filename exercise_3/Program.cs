int check(string x)
{
    while(true)
    { 
        if (int.TryParse(x, out int result))
        {
        return result;
        }
        Console.WriteLine("Введите целое число!");
        x = Console.ReadLine();
    }
    
}

void nums()
{
    Console.WriteLine("Введите кол-во элементов массива: ");
    int enternum = check(Console.ReadLine());
    Console.WriteLine("Введите минимальный порог случайных чисел: ");
    int min = check(Console.ReadLine());
    Console.WriteLine("Введите максимальный порог случайных чисел: ");
    int max = check(Console.ReadLine());
    int[] nums = new int [enternum];
    Random number = new Random();
    for (int i = 0; i < nums.Length; i++ )
    {
        nums[i] = number.Next(min,max+1);
    }
    Console.WriteLine("Массив из случайных чисел : "+ string.Join(" ", nums));

}
nums();
