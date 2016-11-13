using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binNumber = Console.ReadLine();

        long decNumber = 0;

        for (int i = 0; i < binNumber.Length; i++)
        {
            if (binNumber[binNumber.Length - i - 1] == '1')
            {
                decNumber += (long)Math.Pow(2, i);
            }
        }

        Console.WriteLine(decNumber);
    }
}