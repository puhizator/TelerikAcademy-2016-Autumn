using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int result;

        for (int i = 0; i < array.Length; i++)
        {
            result = i * 5;
            Console.WriteLine(result);
        }
    }
}