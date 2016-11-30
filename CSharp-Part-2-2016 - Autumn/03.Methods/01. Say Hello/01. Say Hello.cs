using System;

class Program
{
    static void Main()
    {
        string userName =  Console.ReadLine();
        Console.WriteLine(SayHello(userName));
    }
    static string SayHello(string name)
    {
        string greeting = "Hello, " + name + "!";
        
        return greeting;
    }
}