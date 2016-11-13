//MySolution
//Task - file:///C:/Users/User/AppData/Local/Temp/Rar$EXa0.659/README.html
//Exam Fundamentals 25 April 2016 Evening

using System;

class Program
{
    static void Main()
    {
        int numberOfBuses = int.Parse(Console.ReadLine());
        int groups = 1;
        int groupSpeed = int.Parse(Console.ReadLine());
        for (int i = 1; i < numberOfBuses; i++)
        {
            int speed = int.Parse(Console.ReadLine());
            if (groupSpeed >= speed)
            {
                groupSpeed = speed;
                groups++;
            }

        }

        Console.WriteLine(groups);
    }
}

//TrainerSolution

//using System;

//class Program
//{
//    static void Main()
//    {
//        int count = int.Parse(Console.ReadLine());
//        int groups = 0;
//        int groupSpeed = int.MaxValue;

//        for (int i = 0; i < count; i++)
//        {
//            int busSpeed = int.Parse(Console.ReadLine());
//            if (busSpeed <= groupSpeed)
//            {
//                groups++;
//                groupSpeed = busSpeed;
//            }
//        }
//    }
//}