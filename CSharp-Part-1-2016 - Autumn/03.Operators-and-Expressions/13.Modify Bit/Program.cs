using System;

class Program
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int bitValue = int.Parse(Console.ReadLine());
        ulong result;

        if (bitValue == 0)
        {
            ulong mask = ~((ulong)1 << position);
            result = number & mask;
            Console.WriteLine(result);
        }
        else
        {
            ulong mask = (ulong)1 << position;
            result = number | mask;
            Console.WriteLine(result);
        }        
    }
}