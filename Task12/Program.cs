/*12. Удалить вторую цифру трёхзначного числа*/
/*
void threeNumbers(int num)
{   
    
    if (num.ToString().Length == 3)
    {
        Console.Write(num / 100);
        Console.Write(num % 10);
    }
    else Console.WriteLine("число некорректно");
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
threeNumbers(number);
*/
/*
int threeNumbers(int num)
{   
    
    if (num.ToString().Length == 3)
    {
        Console.Write(num / 100);
        Console.Write(num % 10);
        return num / 100;
    }
    else Console.WriteLine("число некорректно");
    return num % 10;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
threeNumbers(number);
*/
/*
void threeNumbers(int num)  
{
    if (num.ToString().Length == 3)
    {
        Console.Write(num.ToString()[0]);
        Console.Write(num.ToString()[2]); 
    }
    else Console.WriteLine("число некорректно");
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
threeNumbers(number);
*/
int threeNumbers(int num)
{
    if (num.ToString().Length == 3)
    {
        Console.Write(num.ToString()[0]);
        Console.Write(num.ToString()[2]);
        return num;
    }
    else
        Console.Write("Ввод не корректный");
        return num;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
threeNumbers(number);

 