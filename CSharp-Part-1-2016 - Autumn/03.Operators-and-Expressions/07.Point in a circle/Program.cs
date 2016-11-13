using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double circleX = 0;
        double circleY = 0;
        double circleRadius = 2;
        double distance = Math.Sqrt(x * x + y * y);

        //algorithm for testing a point into a circle (x - center_x)^2 + (y - center_y)^2 < radius^2
        if (((x - circleX) * (x - circleX)) + ((y - circleY) * (y - circleY))
            <= (circleRadius * circleRadius))
        {
            Console.WriteLine("yes {0:F2}", distance);
        } 
        else
	    {
            Console.WriteLine("no {0:F2}", distance);
        }
    }
}