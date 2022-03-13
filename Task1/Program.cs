/* 1. По двум заданным числам проверять является ли первое квадратом второго
*/
/*
void square(int num1, int num2)
{
    if (num1 == num2 * num2) Console.WriteLine("Первое число " + num1 + " является квадратом второго числа" + num2);
    else Console.WriteLine("Первое число " + num1 + " не является квадратом второго числа " + num2);
}
Console.WriteLine("Введите 1 число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число ");
int number2 = Convert.ToInt32(Console.ReadLine());
square(number1, number2);
*/

int sqare(int num1, int num2)
{
    if(num1 == num2*num2)
    {
        Console.WriteLine("Первое число " +num1+ " является квардартом второго числа "+ num2); 
        return num1+num2;
     }
    else 
        Console.WriteLine("Первое число " +num1+ " не является квардартом второго числа "+ num2); 
        return num1+num2;
    
}
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int number2 = Convert.ToInt32(Console.ReadLine());
sqare(number1, number2);