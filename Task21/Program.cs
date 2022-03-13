/*21. Программа проверяет пятизначное число на палиндромом.
*/
/*
void palindrome(int num)
{
    if(num.ToString().Length==5)
    {
        if(num.ToString()[0] == num.ToString()[4] && num.ToString()[1] == num.ToString()[3])
        Console.WriteLine("this is a palindrome");
        else Console.WriteLine("it's not a palindrome");
    }
    else Console.WriteLine("the number is not entered correctly");
}
Console.WriteLine("enter a number");
int number = Convert.ToInt32(Console.ReadLine());
palindrome(number);
*/
int palindrome(int num)
{
    if(num.ToString().Length==5)
    {
        if(num.ToString()[0] == num.ToString()[4] && num.ToString()[1] == num.ToString()[3])
        Console.WriteLine("this is a palindrome");
        else Console.WriteLine("it's not a palindrome");
        return num;
    }
    else Console.WriteLine("the number is not entered correctly"); return num;
}
Console.WriteLine("enter a number");
int number = Convert.ToInt32(Console.ReadLine());
palindrome(number);