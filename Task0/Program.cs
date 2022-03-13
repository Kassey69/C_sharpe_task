/*0. Вывести квадрат числа
*/
/*
void square(int num)
{
    int a = num * num;
    Console.WriteLine("Квадрат числа " + num + " = " + a);
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
square(number);
*/
int square(int num)
{
    int a = num * num;
    Console.WriteLine("Квадрат числа " + num + " = " + a);
    return a;
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
square(number);