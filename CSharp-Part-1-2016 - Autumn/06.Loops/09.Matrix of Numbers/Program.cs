﻿using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
            for (int j = i + 1; j < n + i; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.Write("\n");
        }
    }
}