using System;
using System.Linq;


class Program
{
    static void Main()
    {
        //string numberToReverse = Console.ReadLine();

        //string[] arrNumbersToReverse = numberToReverse.Split('.');

        //Console.WriteLine(ReverseNumbers(numberToReverse));

        char[] numberToReverse = Console.ReadLine().ToCharArray();

        Console.WriteLine(Reverse(numberToReverse));

    }

    //static string ReverseNumbers(string arr)
    //{

    //    char[] charArray = arr.ToCharArray();
    //    Array.Reverse(charArray);

    //    return new string (charArray);
    //}


    static string Reverse(char[] arr)
    {
        string result = String.Empty;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            result = result + arr[i];
        }

        return result;
    }
}

