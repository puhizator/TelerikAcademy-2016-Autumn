using System;

class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double p = Math.PI;
        double perimeter = (2 * p * r);
        double area = (p * r * r);

        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
    }
}