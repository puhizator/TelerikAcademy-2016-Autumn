using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        int max = GetMax(a, b);
        max = GetMax(max, c);

        Console.WriteLine(max);
        
    }

    static int GetMax(int one, int two)
    {
        int result = int.MinValue;
        
        if (one > two)
        {
           result = one;
        }
        else
        {
            result = two;
        }

        return result;
    }
}