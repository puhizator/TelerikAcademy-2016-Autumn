using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i == n)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.Write("{0} ", i);
            }
        }
    }
}