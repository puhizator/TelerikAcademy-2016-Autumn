using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double xCenter = 1;
        double yCenter = 1;
        double r = 1.5;

        double leftX = -1;
        double rightX = 5;
        double topY = 1;
        double bottomY = -1;

        bool isInCircle = (x - xCenter) * (x - xCenter) + (y - yCenter) * (y - yCenter) <= r * r;
        bool isInRectangle = (x >= leftX && x <= rightX) && (y <= topY && y >= bottomY);

        if (isInCircle)
        {
            Console.Write("inside circle ");
        }
        else
        {
            Console.Write("outside circle ");
        }
        if (isInRectangle)
        {
            Console.Write("inside rectangle");
        }
        else
        {
            Console.Write("outside rectangle");
        }
    }
}