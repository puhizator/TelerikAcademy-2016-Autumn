using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        string[] array = Console.ReadLine().Split();
        int numberX = int.Parse(Console.ReadLine());
        for (int i = 0; i < array.Length; i++)
        {
            numbers[i] = int.Parse(array[i]);
        }
        int counter = AppearanceCount(numbers, numberX);
        Console.WriteLine(counter);
    }
    static int AppearanceCount(int[] numbers, int numberX)
    {
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == numberX)
            {
                counter++;
            }
        }

        return counter;
    }
}