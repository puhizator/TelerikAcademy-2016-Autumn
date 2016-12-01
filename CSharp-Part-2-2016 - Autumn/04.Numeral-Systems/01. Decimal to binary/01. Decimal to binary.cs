using System;
using System.Text;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine(ConvertDecimalToAny(n, 2));
    }

    static string ConvertDecimalToAny(long number, int numeralBase)
    {
        string result = String.Empty;
        StringBuilder hexNumber = new StringBuilder();
        while (number > 0)
        {
            var digit = number % numeralBase;
            if (digit < 10)
            {
                hexNumber.Insert(0, digit);
            }
            else
            {
                digit = 'A' + (digit % 10);
                char hexValue = (char)digit;
                hexNumber.Insert(0, hexValue);
            }

            number = number / numeralBase;
        }

        result = hexNumber.ToString();
        return result;
    }
}