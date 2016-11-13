using System;

class Program
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        long mask = 1 << position;
        long numberAndMask = number & mask;
        long bit = numberAndMask >> position;
        Console.WriteLine(bit);
    }
}