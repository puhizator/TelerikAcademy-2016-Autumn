using System;

namespace _01.Leap_year
{
    class Program
    {
        static void Main()
        {
            int inputYear = int.Parse(Console.ReadLine());

            bool result = DateTime.IsLeapYear(inputYear);

            if (result == true)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
