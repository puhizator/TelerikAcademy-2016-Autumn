using System;

class Program
{
    static void Main()
    {
        ulong treesCount = ulong.Parse(Console.ReadLine());
        ulong branchesCount = ulong.Parse(Console.ReadLine());
        ulong squirrelCount = ulong.Parse(Console.ReadLine());
        ulong tailsCount = ulong.Parse(Console.ReadLine());
        double result = 0;
        if (treesCount * branchesCount * squirrelCount * tailsCount % 2 != 0)
        {
            result = Convert.ToDouble(treesCount * branchesCount * squirrelCount * tailsCount);
            Console.WriteLine("{0:F3}", result / 7);
        }
        else
        {
            result = Convert.ToDouble(treesCount * branchesCount * squirrelCount * tailsCount);
            Console.WriteLine("{0:F3}", result * 376439);
        }

    }
}