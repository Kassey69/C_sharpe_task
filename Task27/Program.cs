// 27. Определить количество цифр в числе
/*
void count(int num)
{
    int counts = 0;
    while(counts < num.ToString().Length) counts++;
    Console.WriteLine("В числе " + counts + " цифр");
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
count(number);
*/

int count(int num)
{
    int counts = 0;
    while(counts < num.ToString().Length) counts++;
    return counts;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В числе " + count(number) + " цифр");



