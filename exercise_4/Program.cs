/* Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

string [,] createarr(int m,int n)
{
    string [,] array = new string[m,n];
    return array;
}

string [,] newarr = createarr(4,4);

string [,] array(string[,] arr,int right = 1 ,int countposlen = 0,int countposupper = 0,int coun = 0, int down= 0 ,int left= 0 ,int up= 0 ,int pos= 1 ,int i = 0,int j = 0,int count = 1)
{  
    
while(countposlen*(-1)<arr.GetLength(0) || countposupper*(-1) < arr.GetUpperBound(1)+1)
{
    if(pos == right)
    {
        while(coun < arr.GetUpperBound(1)+ 1 + countposupper) 
        {
            arr[i,j] = count.ToString("D2");
            j++;
            count++;
            coun++;
        }
        down = 1;
        right = 0;
        coun = 0;
        pos = 1;
        countposlen -= 1;
        j-=1;
        i++;
        return array(arr,right,countposlen,countposupper,coun,down,left,up,pos,i,j,count);
    }
    if(pos == down)
    {
        while(coun<arr.GetLength(0) + countposlen)
        {
           arr[i,j] = count.ToString("D2");
           i++;
           coun++;
           count++; 
        }
        left = 1;
        down = 0;
        coun = 0;
        i-=1;
        j-=1;
        pos = 1;
        countposupper -= 1;
        return array(arr,right,countposlen,countposupper,coun,down,left,up,pos,i,j,count);
    }
    if(pos == left)
    {
        
        while(coun<arr.GetUpperBound(1)+1+countposupper)
        {
            arr[i,j] = count.ToString("D2");
            count ++;
            coun++;
            j -= 1;
        }
        j+=1;
        up = 1;
        left = 0;
        i-=1;
        pos = 1;
        coun = 0;
        countposlen -= 1;
        return array(arr,right,countposlen,countposupper,coun,down,left,up,pos,i,j,count);
    }
    if(pos == up)
    {
        while(coun < arr.GetLength(0)+countposlen)
        {
            arr[i,j] = count.ToString("D2");
            count ++;
            i-=1;
            coun ++;
        }
        
        i+=1;
        right = 1;
        up = 0;
        coun = 0;
        j++;
        pos = 1;
        countposupper -= 1;
        return array(arr,right,countposlen,countposupper,coun,down,left,up,pos,i,j,count);
    }
}
return arr;   

}

string [,] resultarray = array(newarr);

for(int i = 0;i< resultarray.GetLength(0);i++)
{
    for(int j = 0;j<resultarray.GetUpperBound(1)+1;j++)
    {
        Console.Write($"{resultarray[i,j]}\t");
       
    }
    Console.WriteLine();
}






