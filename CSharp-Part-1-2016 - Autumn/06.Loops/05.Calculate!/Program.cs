using System;

class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        long factorial = 1;
        double s = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            s += (factorial / Math.Pow(x, i));
        }
        Console.WriteLine("{0:F5}", s);
    }
}