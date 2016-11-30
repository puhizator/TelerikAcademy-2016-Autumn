using System;
using System.Collections.Generic;


class Program
{    
    static void Main()
    {
        string[] arrsize = Console.ReadLine().Split();
        string[] array1 = Console.ReadLine().Split();
        string[] array2 = Console.ReadLine().Split();

        //initializing
        List<int> num1Digits = new List<int>();
        List<int> num2Digits = new List<int>();
        for (int i = 0; i < array1.Length; i++)
        {
            num1Digits.Add(int.Parse(array1[i]));
        }

        for (int i = 0; i < array2.Length; i++)
        {
            num2Digits.Add(int.Parse(array2[i]));
        }

        //make equal number of digits
        if (num1Digits.Count < num2Digits.Count)
        {
            for (int i = num1Digits.Count; i < num2Digits.Count; i++)
            {
                num1Digits.Add(0);
            }
        }
        else if (num2Digits.Count < num1Digits.Count)
        {
            for (int i = num2Digits.Count; i < num1Digits.Count; i++)
            {
                num2Digits.Add(0);
            }
        }

        //sum
        List<int> result = new List<int>();
        int over = 0;
        for (int i = 0; i < num1Digits.Count; i++)
        {
            int tempSum = num1Digits[i] + num2Digits[i] + over;
            result.Add(tempSum % 10);
            over = tempSum / 10;
        }

        Console.WriteLine(string.Join(" ", result));
    }
}