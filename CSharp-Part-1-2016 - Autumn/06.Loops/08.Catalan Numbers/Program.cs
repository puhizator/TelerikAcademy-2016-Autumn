using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (1 <= n && n <= 100)
        {
            BigInteger factorial1 = 1;

            for (int i = 1; i <= (2 * n); i++)
            {

                factorial1 *= i;
            }

            BigInteger factorial2 = 1;

            for (int i = 1; i <= (n + 1); i++)
            {

                factorial2 *= i;
            }

            for (int i = 1; i <= n; i++)
            {

                factorial2 *= i;
            }

            Console.WriteLine(factorial1 / factorial2);
        }
        else
        {
            Console.WriteLine(1);
        }

    }
}