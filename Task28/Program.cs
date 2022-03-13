/*28. Подсчитать сумму цифр в числе*/

int sumNumber(int num)
{
    if (num < 10)
        return num;
    int result = num % 10;
    int nextnum = num / 10;
    return result + sumNumber(nextnum);
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumNumber(number));

/*
int sumNumber(int num)
{
    if (num < 10)
        return num;
    
    return num % 10 + sumNumber(num / 10);
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumNumber(number));
*/

//С помощью цклов
/*
int sumNumber(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumNumber(number));
*/
/*
void sumNumber(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;  
    }
    Console.Write(result);  
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
sumNumber(number);
*/