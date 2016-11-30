using System;
using System.Linq;


class Program
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(FirstLarger(array));
    }

    static int FirstLarger(int[] arr)
    {
        int index = -1;

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i -1] && arr[i] > arr[i + 1])
            {
                index = i;
                break;
            }
        }

        return index;
    }
}