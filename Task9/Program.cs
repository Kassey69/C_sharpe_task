 /*9. Показать последнюю цифру трёхзначного числа*/
/*
void threeNumbers(int num)
{
    if(num.ToString().Length==3) Console.WriteLine(num.ToString()[2]);
    else Console.WriteLine("цифра введена не корректно");
}
Console.WriteLine("Введите треззначное число");
int number = Convert.ToInt32(Console.ReadLine());
threeNumbers(number);
*/
/*
int threeNumbers(int num)
{
    if(num.ToString().Length==3)
    {
     Console.WriteLine(num.ToString()[2]); return num;
    }
    else Console.WriteLine("цифра введена не корректно"); return num;
}
Console.WriteLine("Введите треззначное число");
int number = Convert.ToInt32(Console.ReadLine());
threeNumbers(number);
*/
/*
int threeNumbers(int num)
{
    if(num.ToString().Length==3)
    {
     Console.WriteLine(num % 10);
      return num % 10; 
    }
    else Console.WriteLine("цифра введена не корректно"); return num;
}
Console.WriteLine("Введите треззначное число");
int number = Convert.ToInt32(Console.ReadLine());
threeNumbers(number);
*/
void threeNumbers(int num)
{
    if(num.ToString().Length==3)
    {
     Console.WriteLine(num % 10); // берем остаток от деления, он равен 3 цифре 
      return; 
    }
    else Console.WriteLine("цифра введена не корректно"); return;
}
Console.WriteLine("Введите треззначное число");
int number = Convert.ToInt32(Console.ReadLine());
threeNumbers(number);