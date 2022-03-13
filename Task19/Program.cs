/*19. Определить номер четверти плоскости, в которой 
находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
*/
/*
void quarterNUmber(int x, int y)
{
    if (x == 0 || y == 0) Console.WriteLine("данные введены некорректно!");
    else
    {
        if (x > 0 && y > 0) Console.WriteLine("1 quarter");
        if (x < 0 && y > 0) Console.WriteLine("2 quarter");
        if (x < 0 && y < 0) Console.WriteLine("3 quarter");
        if (x > 0 && y < 0) Console.WriteLine("4 quarter");
    }
}
Console.WriteLine("enter x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter y");
int y = Convert.ToInt32(Console.ReadLine());
quarterNUmber(x, y);
*/
int quarterNUmber(int x, int y)
{
        if (x > 0 && y > 0) 
        {Console.WriteLine("1 quarter"); return 1;}
        if (x < 0 && y > 0) 
        {Console.WriteLine("2 quarter"); return 2;}
        if (x < 0 && y < 0) 
        {Console.WriteLine("3 quarter"); return 3;}
        if (x > 0 && y < 0) 
        {Console.WriteLine("4 quarter"); return 4;}
        else
        {Console.WriteLine("данные введены некорректно!"); return 0;}
}
Console.WriteLine("enter x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter y");
int y = Convert.ToInt32(Console.ReadLine());
quarterNUmber(x, y);

