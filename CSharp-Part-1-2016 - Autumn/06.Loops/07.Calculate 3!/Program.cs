using System;
using System.Numerics;

class CalculateCombinaions
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());


        BigInteger factorial1 = 1;
        BigInteger factorial2 = 1;

        for (int i = k + 1; i <= n; i++)
        {
            factorial1 *= i;
        }

        for (int j = 2; j <= (n - k); j++)
        {
            factorial2 *= j;
        }

        BigInteger result = factorial1 / factorial2;
        Console.WriteLine(result);
    }
}