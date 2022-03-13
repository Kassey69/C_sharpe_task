/*13. Выяснить, кратно ли число заданному, если нет, вывести остаток.*/
/*
void multiplicityNumber(double num1, double num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine(num1 + " кратно " + num2);
    }
    else
    {
        Console.WriteLine(num1 + " не кратно " + num2);
        Console.WriteLine("остаток от деления = " + num1 % num2);
    }
}
Console.WriteLine("Введите первое число");
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
double nubver2 = Convert.ToInt32(Console.ReadLine());
multiplicityNumber(number1, nubver2);
*/
double multiplicityNumber(double num1, double num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine(num1 + " кратно " + num2); return num1 + num2;
    }
    else
    {
        Console.WriteLine(num1 + " не кратно " + num2);
        Console.WriteLine("остаток от деления = " + num1 % num2);
        return num1 + num2;
    }
}
Console.WriteLine("Введите первое число");
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
double nubver2 = Convert.ToInt32(Console.ReadLine());
multiplicityNumber(number1, nubver2);

//число кратно 3, значит делится на 3 без остатка