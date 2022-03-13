/*25. Найти сумму чисел от 1 до А*/
/*
void sumNumbers(int num)
{
    int w = 1;
    int sum = 0;
    while (w <= num)
    {
        sum = sum + w;
        Console.WriteLine(sum );
        w++;
    }
}

Console.WriteLine("enter number");
int a = Convert.ToInt32(Console.ReadLine());
sumNumbers(a);
*/
void sumNumbers(int num)
{  
     int sum2 = 0;
    for (int i = 1; i <= num; i++) 
    {
    
        int sum1 = sum2 + i;
            sum2 = sum1;
         Console.Write(i+"+↓  ");
        Console.WriteLine(sum2);
    }
    
    /*
    int w = 1;
    int sum = 0;
    while (w <= num)
    {
        sum = sum + w;
        Console.WriteLine(w+"="+sum);
        w++;
    }
    return sum;
}
*/
}
Console.WriteLine("enter number");
int a = Convert.ToInt32(Console.ReadLine());
sumNumbers(a);