using System;

class Program
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();


        Console.WriteLine(ConvertFromAnyToDec(binaryNumber, 2));
    }


    static long ConvertFromAnyToDec(string number, int numeralBase)
    {
        long result = 0;
        foreach (char digit in number)
        {
            result = result * numeralBase + (digit - '0');
        }

        return result;
    }
}