using System;

namespace _06.Surface_by_two_sides_and_angle
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double degree = double.Parse(Console.ReadLine());
            double angle = Math.PI * degree / 180;

            double result = (a * b * Math.Sin(angle) / 2);
            Console.WriteLine("{0:F2}", result);
        }
    }
}
