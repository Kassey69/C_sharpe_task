/*17. По двум заданным числам проверять является ли одно квадратом другого*/
/*
void sqareNamber(double num1, double num2)
{
    if (num2 == num1 / num2) Console.WriteLine(num2 + " is square " + num1);
    else Console.WriteLine(num2 + " is not square " + num1);
}
Console.WriteLine("enter number1");
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number2");
double number2 = Convert.ToInt32(Console.ReadLine());
sqareNamber(number1, number2);
*/
double sqareNamber(double num1, double num2)
{
    if (num2 == num1 / num2)
    {
        Console.WriteLine(num2 + " is square " + num1); return num1 + num2;
    }
    else Console.WriteLine(num2 + " is not square " + num1); return num1 + num2;
}
Console.WriteLine("enter number1");
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number2");
double number2 = Convert.ToInt32(Console.ReadLine());
sqareNamber(number1, number2);