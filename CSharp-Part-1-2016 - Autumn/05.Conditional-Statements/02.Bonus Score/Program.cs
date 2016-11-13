using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        if (1 <= input && input <= 3)
        {
            Console.WriteLine((input * 10));
        }

        else if (4 <= input && input <= 6)
        {
            Console.WriteLine((input * 100));
        }
        else if (7 <= input && input <= 9)
        {
            Console.WriteLine((input * 1000));
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}