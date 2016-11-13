// 25 April 2016 Morning
using System;

class NumberOfPages
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 1; i <= n; i++)
        {
            int lenght = i.ToString().Length;
            counter = counter + lenght;
        }
        Console.WriteLine(counter);
    }
}
