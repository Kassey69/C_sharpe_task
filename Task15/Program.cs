/*15. Дано число. Проверить кратно ли оно 7 и 23 */
/*
void multipleNumber(int num1, int num2, int num3)
{
    if (num1 % num2 == 0 && num1 % num3 == 0)
        Console.WriteLine("Number " + num1 + " multiple " + num2 + " and " + num3);
    else Console.WriteLine("Number " + num1 + " not multiple " + num2 + " and " + num3);
}
Console.WriteLine("enter number1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number3 ");
int number3 = Convert.ToInt32(Console.ReadLine());
multipleNumber(number1, number2, number3);
*/
int multipleNumber(int num1, int num2, int num3)
{
    if (num1 % num2 == 0 && num1 % num3 == 0)
    {
        Console.WriteLine("Number " + num1 + " multiple " + num2 + " and " + num3);
        return num1 + num2 + num3;
    }
    else Console.WriteLine("Number " + num1 + " not multiple " + num2 + " and " + num3);
    return num1 + num2 + num3;
}
Console.WriteLine("enter number1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number3 ");
int number3 = Convert.ToInt32(Console.ReadLine());
multipleNumber(number1, number2, number3);