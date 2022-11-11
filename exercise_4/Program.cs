int check(string x)
{
    while (true)
    {
        if (int.TryParse(x, out int result)) { return result; }
        Console.WriteLine("Введите целое число!");
        x = Console.ReadLine();
    }
}

int input = check(Console.ReadLine());

int[] array()
{
    int[] array = new int[input];
    return array;
}

int[] array1 = array();

int requrse(int x = 1, int i = 0, int count = 0)
{
    if(i < input)
    {
        while (count < x && i < input)
        {
            array1[i] = x;
            i++;
            count++;
        }   
        count = 0;
        x++;
        return requrse(x, i, count = 0);
    }
    return x;
    
}

requrse();
Console.WriteLine(string.Join(" ", array1));

