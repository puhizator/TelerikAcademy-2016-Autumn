using System;

class Program
{
    static void Main()
    {
        // Convert from any classic base to any base in C#** - works for 2,8,10,16
        string number = "236476736";
        int fromBase = 10;
        int toBase = 2;

        string result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
        Console.WriteLine(result);
    }
}