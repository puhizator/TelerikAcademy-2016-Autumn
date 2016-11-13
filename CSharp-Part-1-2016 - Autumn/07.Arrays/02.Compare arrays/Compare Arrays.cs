using System;

class Program
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        string result = string.Empty;
        if (first.Length > second.Length)
        {
            result = ">";
        }
        else if (first.Length < second.Length)
        {
            result = "<";
        }
        else
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] > second[i])
                {
                    result = ">";
                    break;
                }
                if (first[i] < second[i])
                {
                    result = "<";
                    break;
                }
                else
                {
                    result = "=";
                }
            }
        }
        Console.WriteLine(result);

    }
}