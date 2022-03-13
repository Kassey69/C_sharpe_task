/*16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным */
/*
void dayweek(int day)
{
    if (day >= 1 && day <= 7)
    {
        if(day >=1 && day <=5) Console.WriteLine("weekdays");
        else Console.Write("weekends");
    }
    else Console.WriteLine("dayweek is entered incorrectly");
}
Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
dayweek(number);
*/
int dayweek(int day)
{
    if (day >= 1 && day <= 7)
    {
        if(day >=1 && day <=5) 
        {
        Console.WriteLine("weekdays"); return day;
        }
        else Console.Write("weekends"); return day;
    }
    else Console.WriteLine("dayweek is entered incorrectly"); return day;
}
Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
dayweek(number);