//Task file:///C:/Users/User/AppData/Local/Temp/Rar$EXa0.140/README.html
//Exam Fundamentals 25 April 2016 Evening
using System;

class Birds
{
    static void Main()
    {
        double birds = double.Parse(Console.ReadLine());
        long feathers = long.Parse(Console.ReadLine());
        long magicNumber = 123123123123;
        double divider = 317;
        double average = (feathers / birds);
        double result;

        if (birds == 0 && feathers == 0)
        {
            result = 0;
        }
        else if (birds % 2 == 0)
        {
            result = (average * magicNumber);
        }
        else
        {
            result = (average / divider);
        }
        Console.WriteLine("{0:F4}", result);
    }
}