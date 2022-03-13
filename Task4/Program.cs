/*4. Найти максимальное из трех чисел*/
/*
void Max(int num1, int num2, int num3)
{
    int max = num1;
    if (max < num2) max = num2;
    if (max < num3) max = num3;
    Console.WriteLine("Максимальное число равно = " + max);
}
Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int number3 = Convert.ToInt32(Console.ReadLine());
Max(number1, number2, number3);
*/
int Max(int num1, int num2, int num3)
{
    int max = num1;
    if (max < num2) max = num2; 
    if (max < num3) max = num3; 
    return max;
}
Console.WriteLine("Введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int number3 = Convert.ToInt32(Console.ReadLine());
Max(number1, number2, number3);
Console.WriteLine("Максимальное число равно = " + Max(number1, number2,number3));