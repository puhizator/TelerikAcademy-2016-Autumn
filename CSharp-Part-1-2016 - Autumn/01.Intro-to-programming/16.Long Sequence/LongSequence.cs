using System;

class LongSequence
{
    static void Main()
    {
        int length = 10;
        int number = 2;
        for (int i = 0; i < length; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(number + i);
            }
            else
            {
                Console.WriteLine(-(number + i));
            }
        }
    }
}