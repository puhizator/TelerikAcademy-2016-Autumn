using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];

        array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(checkNeighbours(array));
        
    }

    static int checkNeighbours(int[] arrayToCheck)
    {
        int counter = 0;

        for (int i = 1; i < arrayToCheck.Length - 1; i++)
        {
            if (arrayToCheck[i] > arrayToCheck[i-1] && arrayToCheck[i] > arrayToCheck[i + 1])
            {
                counter++;
            }
        }

        return counter;
    }
}