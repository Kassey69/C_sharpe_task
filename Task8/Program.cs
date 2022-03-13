/*8. Показать четные числа от 1 до N */
/*
void evenNumbers(int num)
{
    int a = 1;
    while (a <= num)
    {
        if (a % 2 == 0)
            Console.Write(a + " ");
        a++;
    }
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
evenNumbers(number);
*/
int evenNumbers(int num)
{
    int a = 1;
    while (a <= num)
    {
        if (a % 2 == 0)
            Console.Write(a + " ");
        a++;
    }
    return a;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
evenNumbers(number);