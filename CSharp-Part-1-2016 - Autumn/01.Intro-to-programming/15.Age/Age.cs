using System;

class Age
{
    static void Main()
    {

        int ageNow, ageAfterTen;
        string input = Console.ReadLine();
        
        DateTime user = DateTime.ParseExact(input, "mm.dd.yyyy", null);

        ageNow = (DateTime.Now.Year - user.Year);
        ageAfterTen = (ageNow + 10);

        Console.WriteLine(ageNow);
        Console.WriteLine(ageAfterTen);
    }
}