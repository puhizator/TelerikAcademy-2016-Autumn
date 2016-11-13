using System;

class Program
{
    static void Main()
    {
        int arrLength = int.Parse(Console.ReadLine());
        int[] arr = new int[arrLength];
        int sum = 0;
        int maxSum = 0;

        for (int i = 0; i < arrLength; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
            if (sum < arr[i])
            {
                sum = arr[i];
            }
            if (sum > maxSum)
            {
                maxSum = sum;
            }    
        }
        Console.WriteLine(maxSum);
    }
}