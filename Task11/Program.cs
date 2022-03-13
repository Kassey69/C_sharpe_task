/*11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа*/

/*
void moreDigit(int num)
{
    int a = num / 10;  //первая цифра
    int b = num % 10; //вторая йифра
    int max = a;
    if (a < b) max = b; 
    Console.WriteLine(max);  
}
int nember = new Random().Next(10, 90);
Console.WriteLine(nember);  
moreDigit(nember);
*/
int moreDigit(int num)
{
    int a = num / 10;
    int b = num % 10;
    int max = a;
    if (a < b) max = b;
    Console.WriteLine(max);
    return max;
}
int number = new Random().Next(10,90);
Console.WriteLine(number);
moreDigit(number);