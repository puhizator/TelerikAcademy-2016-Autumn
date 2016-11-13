using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int counter = 1;
        int counterMax = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            counterMax = Math.Max(counter, counterMax);
        }
        Console.WriteLine(counterMax);
    }
}