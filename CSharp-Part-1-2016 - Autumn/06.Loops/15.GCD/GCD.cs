using System;

class Program
    {
        static void Main()
        {
        string[] nums = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int firstNum = int.Parse(nums[0]);
        int secondNum = int.Parse(nums[1]);
        int a = Math.Abs(firstNum);
        int b = Math.Abs(secondNum);

        // Euclidean algorithm
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine(a);
    }
    }