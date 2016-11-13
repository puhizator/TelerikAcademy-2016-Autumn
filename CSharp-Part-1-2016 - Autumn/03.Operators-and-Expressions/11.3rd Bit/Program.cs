using System;

    class Program
    {
        static void Main()
        {
        int p = 3;
        int number = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        Console.WriteLine(bit);
        }
    }