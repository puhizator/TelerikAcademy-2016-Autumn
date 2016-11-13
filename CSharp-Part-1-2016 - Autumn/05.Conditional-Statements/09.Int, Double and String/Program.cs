using System;

class Program
{
    static void Main()
    {
        string variable = Console.ReadLine();

        switch (variable)
        {
            case "integer":
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a + 1);
                break;
            case "real":
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", b + 1);
                break;
            default:
                string text = Console.ReadLine();
                Console.WriteLine("{0}*", text);
                break;
        }
    }
}