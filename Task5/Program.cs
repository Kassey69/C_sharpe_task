/*5. Написать программу вычисления значения функции y = f(a)
y = 
*/
/*
void function(double a)
{
    double y = Math.Pow(a, 2);
    Console.WriteLine("Функция равна " + y);
}
Console.WriteLine("Введите число");
double a = Convert.ToInt32(Console.ReadLine());
function(a);
//Для выполнения различных математических операций в библиотеке классов .NET 
//предназначен класс Math. Он является статическим, поэтому все его методы также являются статическими.
*/
double function(double a)
{
    double y = Math.Pow(a, 3); 
    Console.WriteLine("Функция равна " + y);
    return y;
}
Console.WriteLine("Введите число");
double a = Convert.ToInt32(Console.ReadLine());
function(a);