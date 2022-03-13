/*2. Даны два числа. Показать большее и меньшее число*/
/*
void MaxMin(int num1, int num2)
{
    if (num1 > num2) Console.WriteLine("Число " + num1 + " Больше числа " + num2);
    else Console.WriteLine("Число " + num2 + " Больше числа " + num1);
}
Console.Write("Введите 1 число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число ");
int number2 = Convert.ToInt32(Console.ReadLine());
MaxMin(number1, number2);
*/
int MaxMin(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.WriteLine("Число " + num1 + " Больше числа " + num2);
        return num1+num2;
    }
    else Console.WriteLine("Число " + num2 + " Больше числа " + num1);
    return num1+num2;
}
Console.Write("Введите 1 число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число ");
int number2 = Convert.ToInt32(Console.ReadLine());
MaxMin(number1, number2);