/*10. Показать вторую цифру трёхзначного числа*/
/*
void threeNumbers(int num)
{
    if (num.ToString().Length == 3) Console.WriteLine(num.ToString()[1]);
    else Console.WriteLine("число не корректно");
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
threeNumbers(number);
*/
/*
void threeNumbers(int num)
{
    if (num.ToString().Length == 3) 
    Console.WriteLine(num.ToString()[1]);
    else Console.WriteLine("число не корректно");
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
threeNumbers(number);
*/
/*
void threeNumbers(int num)
{
    if(num.ToString().Length==3) Console.WriteLine((num/10) % 10);
    else Console.WriteLine("Число введено не коректно");
}
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine()); // int number = int.Parse(Console.ReadLine());
threeNumbers(number);
*/
int threeNumbers(int num)
{
    if(num.ToString().Length==3)
    {
     Console.WriteLine((num/10) % 10); return (num/10) % 10;
    }
    else Console.WriteLine("Число введено не коректно"); return num;
}
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine()); // int number = int.Parse(Console.ReadLine());
threeNumbers(number);