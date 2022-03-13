/*26. Возведите число А в натуральную степень B используя цикл */

void numberDegree(double a, double B)
{
    for (double i = 1; i <= B; i++) 
    {
     double res = Math.Pow(a, i);
     Console.WriteLine(a+" ^ "+i+" = "+res+"  ");
    }
}
Console.WriteLine("enter number A");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter degree B");
double B = Convert.ToInt32(Console.ReadLine());
numberDegree(a,B);