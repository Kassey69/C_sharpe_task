/* 3. По заданному номеру дня недели вывести его название
*/
/*
void dayweek(int day)
{
    if (day >= 1 && day <= 7)
    {
        if(day == 1) Console.Write("Monday");
        if(day == 2) Console.Write("Вторник");
        if(day == 3) Console.Write("Среда");
        if(day == 4) Console.Write("четверг");
        if(day == 5) Console.Write("Friday");
        if(day == 6) Console.Write("Суббота");
        if(day == 7) Console.Write("Sundey");
    }
        else Console.Write("Такого дня недели не существует");
}
    Console.WriteLine("Введите день недели от 1 до 7");
    int day = Convert.ToInt32(Console.ReadLine());
    dayweek(day);
    */
int dayweek(int day)
{
    if (day >= 1 && day <= 7)
    {
        if(day == 1) 
        {
             Console.Write("Monday");
             return 1;
        }
        if(day == 2)
        {
         Console.Write("Вторник"); return 2;
        }
        if(day == 3)
        {
             Console.Write("Среда"); return 3;
        }
        if(day == 4) 
        {
        Console.Write("четверг"); return 4;
        }
        if(day == 5) 
        {
        Console.Write("Friday"); return 5;
        }
        if(day == 6) 
        {
        Console.Write("Суббота"); return 6;
        }
        if(day == 7) 
        {
        Console.Write("Sundey"); return 7;
        }
    }
        else Console.Write("Такого дня недели не существует");
        return day;
}
    Console.WriteLine("Введите день недели от 1 до 7");
    int day = Convert.ToInt32(Console.ReadLine());
    dayweek(day);