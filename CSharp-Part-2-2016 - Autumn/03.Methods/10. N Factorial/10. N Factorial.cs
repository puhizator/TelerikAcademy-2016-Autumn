using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(nFactorial(n));
    }

    static BigInteger nFactorial (int n)
    {
        BigInteger result = 1;

        for (int i = 1; i <= n ; i++)
        {
            result = result * i;

        }

        return result;
    }
}