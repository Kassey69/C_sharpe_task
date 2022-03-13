/*Задача подразумевает работу исключительно с условным 
оператором if и циклами, всё это мы разбирали. Её интересность в том, 
чтобы сам алгоритм составить. Тут не получится сходу всё написать, задачка на логику

Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
Вывести на экран первые два максимальных и первые два минимальных числа 
из ряда введенных чисел. А теперь самое интересное: 
создавать массивы в процессе решения запрещено */

Console.WriteLine("enter i");
int i = Convert.ToInt32(Console.ReadLine());
int max1 = i; int max2 = i; int min1 = i; int min2 = i;
while (i != 0)
{
    i = Convert.ToInt32(Console.ReadLine());
    if (i < min1 && i != 0)
    {
        min2 = min1;
        min1 = i;
    }
    else
    {
        if (i != min1 && i < min2 && i!=0)
            min2 = i;
    }
    if (i > max1)
    {
        max2 = max1;
        max1 = i;
    }
    else
    {
        if (i != max1 && i > max2)
            max2 = i;
    }
    Console.WriteLine(" 1 минимум = "+min1 + " 2 мин = "+ min2+" 1 максимум = "+max1+" 2 макс = "+max2);
}
















/*  

}
  int size = i.ToString().Length;
  int firstmax = i.ToString()[0];
  int secondmax = i.ToString()[0];
  if (i.ToString()[1] > firstmax) firstmax = i.ToString()[1];
  else secondmax = i.ToString()[1];
  int count = 2;
  while (count < size)
  {

      if (i.ToString()[count] > firstmax) 
      {
          secondmax = firstmax;
      firstmax = i.ToString()[count];
      }
      else
      { 
      if (i.ToString()[count] > secondmax)
      {
          secondmax = i.ToString()[count];
          count = count +1; 
      }
    }

Console.WriteLine(secondmax);
}




 */



/*
        if (i < min1 && i != 0) min1 = i;
        min2 = min1; */


