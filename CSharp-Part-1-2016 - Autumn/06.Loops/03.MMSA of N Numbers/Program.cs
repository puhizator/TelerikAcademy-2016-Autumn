using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        double min = double.MaxValue;
        double max = double.MinValue;

        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
            sum += number;
        }
        double average = sum / n;
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", average);

        // SECOND WAY WITH USING SYSTEM.LINQ - THERE WE CAN FIND array.Min() -> array.Max() and etc.
        //int n = int.Parse(Console.ReadLine());

        //double[] array = new double[n];

        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] = double.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("min={0:F2}", array.Min());
        //Console.WriteLine("max={0:F2}", array.Max());
        //Console.WriteLine("sum={0:F2}", array.Sum());
        //Console.WriteLine("avg={0:F2}", array.Average());
    }
}