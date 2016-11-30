using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());

        int[] array = new int[arrSize];
        array = Console.ReadLine().Split().Select(int.Parse).ToArray();


    }
}