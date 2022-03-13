/*7. Показать числа от -N до N*/
/*
void Number(int num1, int num2)
{
    while (num1 <= num2)
    {
        Console.Write(num1 + " ");
        num1++;
    }
}
Console.WriteLine("Введите отрицательное число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 >= 0) 
{
Console.WriteLine("Число введено некорректно "); return;
}
Console.WriteLine("Введите положительное число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 <= 0) 
{
Console.WriteLine("Число введено некорректно "); return;
}
Number(number1, number2);
*/
/*
void Number(int num1, int num2)
{
    if (num1 >= 0 || num2 <= 0)
    {
        Console.WriteLine("Числа введены некорректно ");
        return; // в данном случае значение не возвращается как в int, 
                    //если попытаться ввести num1 или что уцгодно будет ошибка
    }
    while (num1 <= num2)
    {
        Console.Write(num1 + " ");
        num1++;
    }
}
Console.WriteLine("Введите отрицательное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число");
int number2 = Convert.ToInt32(Console.ReadLine());
Number(number1, number2);
*/

int Numbers(int num1, int num2)
{
    while (num1 <= num2)
    {
        Console.Write(num1 + " ");
        num1++;
    }
    return num1;
}
Console.WriteLine("Введите отрицательное число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 >= 0) 
{
Console.WriteLine("Число введено некорректно "); return;
}
Console.WriteLine("Введите положительное число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 <= 0) 
{
Console.WriteLine("Число введено некорректно "); return;
}
Numbers(number1, number2);
