/*20. Задать номер четверти, показать диапазоны для возможных координат
*//*
void quarterNumber(int quarternum)
{
    switch(quarternum)
    {
        case 1:
        {
            Console.WriteLine("В этой четверти расположены такие коорджинаты x > 0 && y > 0"); break;
        }
        case 2:
        {
            Console.WriteLine("В этой четверти расположены такие коорджинаты x < 0 && y > 0"); break;
        }
        case 3:
        {
            Console.WriteLine("В этой четверти расположены такие коорджинаты x < 0 && y < 0"); break;
        }
        case 4:
        {
            Console.WriteLine("В этой четверти расположены такие коорджинаты x > 0 && y < 0"); break;
        }
        default:
        {
            Console.WriteLine("Такой четверти не существует"); break;
        }
    }
}
Console.WriteLine("Введите номер четверти");
int quarternum = Convert.ToInt32(Console.ReadLine());
quarterNumber(quarternum);
*/
/*
void quarterNumber(int quarternum)
{
    if(quarternum >=1 && quarternum<=4)
    {
    if(quarternum == 1) Console.WriteLine("диапазоны координат в этой четверти x > 0 && y > 0");
    if(quarternum == 2) Console.WriteLine("диапазоны координат в этой четверти x < 0 && y > 0");
    if(quarternum == 3) Console.WriteLine("диапазоны координат в этой четверти x < 0 && y < 0");
    if(quarternum == 4) Console.WriteLine("диапазоны координат в этой четверти x > 0 && y < 0");
    }
    else Console.WriteLine("Такой четверти не существует");
}      
Console.WriteLine("Введите номер четверти");
int quarternum = Convert.ToInt32(Console.ReadLine());
quarterNumber(quarternum);
*/
int quarterNumber(int quarternum)
{
    if(quarternum >=1 && quarternum<=4)
    {
    if(quarternum == 1) 
    {Console.WriteLine("диапазоны координат в этой четверти x > 0 && y > 0"); return 1;}
    if(quarternum == 2) 
    {Console.WriteLine("диапазоны координат в этой четверти x < 0 && y > 0"); return 2;}
    if(quarternum == 3) 
    {Console.WriteLine("диапазоны координат в этой четверти x < 0 && y < 0"); return 3;}
    if(quarternum == 4) 
    {Console.WriteLine("диапазоны координат в этой четверти x > 0 && y < 0"); return 4;}
    }
    else Console.WriteLine("Такой четверти не существует"); return 0;
}      
Console.WriteLine("Введите номер четверти");
int quarternum = Convert.ToInt32(Console.ReadLine());
quarterNumber(quarternum);