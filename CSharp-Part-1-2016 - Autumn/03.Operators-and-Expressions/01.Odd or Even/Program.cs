using System;


class Program
{
    static void Main()
    {
        // Solution with Ternary operator
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(((number % 2) == 0) ? "even " + number : "odd " + number);

        // Solution with if-else statement
        int num = int.Parse(Console.ReadLine());

        if ((num % 2) == 0)
        {
            Console.WriteLine("even "+ num);
        }
        else
        {
            Console.WriteLine("odd " + num);
        }
    }
}