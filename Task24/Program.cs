/*24. Найти кубы чисел от 1 до N*/
/*
void cubesNumbers(double num)
{
    double a = 1;
    while (a < num)
    {
        double b = Math.Pow(a, 3);
        Console.WriteLine(a + " * " + a + " * "+ a +" = " + b);
        a++;
    }
}
Console.WriteLine("Enter number");
double number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.Write("incorrect value entered");
cubesNumbers(number);
*/
double cubesNumbers(double num)
{
    double a = 1;
    while (a <= num)
    {
        double b = Math.Pow(a, 3);
        Console.WriteLine(a + " * " + a + " * "+ a +" = " + b);
        a++;
    }
    return a;
}
Console.WriteLine("Enter number");
double number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.Write("incorrect value entered");
cubesNumbers(number);