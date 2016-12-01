using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());

        int[] array = new int[arrSize];
        array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] arrayResult = sortArray(array);

        for (int i = 0; i < arrayResult.Length; i++)
        {            
            if (i < arrayResult.Length)
            {
                Console.Write("{0} ", arrayResult[i]);
            }
            else
            {
                Console.WriteLine("{0}", arrayResult[i]);
            }
        }
    }

    static int[] sortArray (int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }

        return array;
    }
}