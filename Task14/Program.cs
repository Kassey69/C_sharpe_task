/*14. Найти третью цифру числа или сообщить, что её нет*/
/*
void threeNumber(int num)
{
    if (num.ToString().Length >= 3) Console.WriteLine(num.ToString()[2]);
    else Console.WriteLine("no three number");
}
Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
threeNumber(number);
*/
int threeNumber(int num)
{
    if (num.ToString().Length >= 3) 
    {
    Console.WriteLine(num.ToString()[2]); return num.ToString()[2];
    }
    else Console.WriteLine("no three number"); return num;
}
Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
threeNumber(number);