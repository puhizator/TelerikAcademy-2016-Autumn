using System;

class Program
{
    static void Main()
    {
        float weight = float.Parse(Console.ReadLine());
        float gravity = 0.17F;
        float mWeight = (gravity * weight);
        Console.WriteLine("{0:F3}", mWeight);
    }
}