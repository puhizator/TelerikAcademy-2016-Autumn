using System;

class Program
{
    static void Main()
    {
        // read the input from the console, parse it to int
        int number = int.Parse(Console.ReadLine());
        // create bool isPrime
        bool isPrime = true;
        // if the n is less than 2, return false
        if (number <= 1)
        {
            isPrime = false;
        }
        // i start from 2 (all Prime numbers are divisible by 1 and itself without reminder), loop until the number,
        // add +1 to divider after each cycle and check again. If number % 2,3,4 etc give 0 before the end
        // the number isNotPrime.
        //Example with number-21 - (row 12) 21 is not <= 1, it's bigger.
        // number(21) % i(2) == 0 - False, i  = 3, return to row 24.
        // number(21) % i(3) == 0 - True, isPrime = false; break and exit of the loop.
        else
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }            
        }
        // Write isPrime(True/False) as you convert it to string and make it lower to receive (true/false)
        Console.WriteLine(isPrime.ToString().ToLower());
    }
}