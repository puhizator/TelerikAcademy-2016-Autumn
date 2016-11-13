//условие file:///C:/Users/User/AppData/Local/Temp/Rar$EXa0.565/README.html
//first Solution
//Exam Fundamentals 25 April 2016 Evening

using System;

//class Program
//{
//    static void Main()
//    {
//        int digits = int.Parse(Console.ReadLine()); // read input
//        int pages = 0;
//        for (int page = 1; digits != 0; page++)
//        {
//            pages++;
//            if (page < 10)
//            {
//                digits -= 1;
//            }
//            else if (page < 100)
//            {
//                digits -= 2;
//            }
//            else if (page < 1000)
//            {
//                digits -= 3;
//            }
//            else if (page < 10000)
//            {
//                digits -= 4;
//            }
//            else if (page < 100000)
//            {
//                digits -= 5;
//            }
//            else if (page < 1000000)
//            {
//                digits -= 6;
//            }
//        }

//        Console.WriteLine(pages); // write output
//    }
//}

//Second Solution
//using System;

class Program
{
    static void Main()
    {
        int digits = int.Parse(Console.ReadLine()); // read input
        int pages = 0;
        for (int page = 1; digits != 0; page++)
        {
            pages++;
            digits -= page.ToString().Length; // вместо горното решение, 
            //вадим дължината на стринга -1-2-3
        }

        Console.WriteLine(pages); // write output
    }
}