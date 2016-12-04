using System;

namespace _05.Triangle_surface_by_three_sides
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double s = (a + b + c) / 2;
            double result = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("{0:F2}", result);
        }
    }
}
