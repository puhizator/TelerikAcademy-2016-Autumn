using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split();
        double oddProduct = 1;
        double evenProduct = 1;

        for (int i = 0; i < n; i++)
        {            
            if (i % 2 == 0)
            {
                oddProduct *= int.Parse(numbers[i]);
            }
            else
            {
                evenProduct *= int.Parse(numbers[i]);
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }
    }
}