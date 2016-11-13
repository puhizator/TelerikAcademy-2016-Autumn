using System;

class printASCII
{
    static void Main()
    {
        for (int i = 33; i < 127; i++)
        {
            Console.Write((char)i);
        }
    }
}
