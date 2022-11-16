/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */
/* int [] input = []; {0, 7, 8, -2, -2 }; */

string [] array(string input) // Переводим введиную строку в массив
{
    string [] array = new string[input.Length];
    for(int i = 0; i<input.Length; i++)
    {
        array[i] = input[i].ToString();
    }
    return array;

}

string [] check (string [] input) // проверка ввода пользователем
{
    while(true)
    {
        if((int.TryParse(input[0],out int result)||input[0] == "-") && int.TryParse(input[^1],out int result2)  )
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (int.TryParse(input[i], out int result1) || input[i] == "," || input[i] == "-")
                {
                }
                else 
                {
                    i = 0;
                    Console.WriteLine("Введите целые числа через запятую!");
                    input = array(Console.ReadLine());
                }
            }
        return input;
    
        }

    Console.WriteLine("Введите целые числа через запятую!");
    input = array(Console.ReadLine());
    }
}


int [] intarray (string []array) // Переводим массив строк в массив чисел
{
    int n = 1;
    for (int i = 0 ; i < array.Length; i++)
    {           
        if (array[i] == ",")  // Опредлеяем размер массива чисел
        {
            n++;
        }
    }
    int [] intarray = new int[n];
    int j = 0;
    int f = 0;
    string numbers ="";
    while ( j < intarray.Length)
    {
        while( f < array.Length && array[f] != ",") // определяем массив чисел
        {
            numbers = numbers + array[f];
            f ++;
        }
        f++;
        intarray[j] = Convert.ToInt32(numbers);
        numbers = "";
        j++;
        
    }
    return intarray;
}
int [] massive = intarray(check(array(Console.ReadLine())));
int result (int [] arrayinput) // проверка на кол-во чисел >0
{
    int count = 0;
    for(int i=0; i<arrayinput.Length; i++)
    {
        if (arrayinput[i] > 0){ count ++;}
    
    }
    return count;
}
Console.WriteLine($"Кол-во чисел больше 0 : {result(massive)}");






