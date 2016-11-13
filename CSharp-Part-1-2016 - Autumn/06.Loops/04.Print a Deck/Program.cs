using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n;
        if (input == "J")
        {
            n = 11;
        }
        else if (input == "Q")
        {
            n = 12;
        }
        else if (input == "K")
        {
            n = 13;
        }
        else if (input == "A")
        {
            n = 14;
        }
        else
        {
            n = int.Parse(input);
        }
       
        for (int i = 2; i <= n; i++)
        {
            if (i == 11)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
            }
            else if (i == 12)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
            }
            else if (i == 13)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
            }
            else if (i == 13)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "A");
            }
            else
            {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }
        }
    }
}