 /*6. Выяснить является ли число чётным*/
 /*
 void evenNumber(int num)
 {
     if(num % 2 == 0) Console.Write("Число четное");
     else Console.Write("Число нечетное");
 }
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
evenNumber(number);
*/
int evenNumber(int num)
 {
     if(num % 2 == 0) 
     {
         Console.Write("Число четное"); return num;
     }
     else Console.Write("Число нечетное"); return num;
 }
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
evenNumber(number);