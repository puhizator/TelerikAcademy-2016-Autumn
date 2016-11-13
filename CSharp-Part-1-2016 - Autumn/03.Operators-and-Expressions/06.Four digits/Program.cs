﻿using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int d = number % 10;
        int c = (number / 10) % 10;
        int b = (number / 100) % 10;
        int a = (number / 1000) % 10;

        Console.WriteLine(a + b + c + d);
        // second condition - long way
        //Console.WriteLine(Convert.ToString(d)+ Convert.ToString(c)+ Convert.ToString(b)
        //    + Convert.ToString(a));
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);

    }
}