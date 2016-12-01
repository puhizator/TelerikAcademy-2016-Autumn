using System;

class Program
{
    static void Main()
    {

        string hexToConvert = Console.ReadLine();
        Console.WriteLine(ConvertFromHexToDeC(hexToConvert));

    }


    static long ConvertFromHexToDeC(string number)
    {
        long result = 0;

        foreach (var digit in number)
        {
            int digitValue;

            if (char.IsDigit(digit))
            {
                digitValue = digit - '0';
            }
            else
            {
                digitValue = digit - 'A' + 10;
            }
            result = result * 16 + digitValue;
        }

        return result;
    }
}