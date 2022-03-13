/*23. Показать таблицу квадратов чисел от 1 до N 
*/
/*
void tableSquares(int num)
{
    int a = 1;
    while (a < num)
    {
        int b = a * a;
        Console.WriteLine(a + " * " + a + " = " + b);
        a++; //a+=2;
    }
}
Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.Write("incorrect value entered");
tableSquares(number);
*/
int tableSquares(int num)
{
    int a = 1;
    while (a <= num)
    {
        int b = a * a;
        Console.WriteLine(a + " * " + a + " = " + b);
        a++; //a+=2;
    }
    return a;
}
Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.Write("incorrect value entered");
    tableSquares(number);