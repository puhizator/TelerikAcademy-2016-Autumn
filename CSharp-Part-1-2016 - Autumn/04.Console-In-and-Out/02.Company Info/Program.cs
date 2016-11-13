using System;

class Program
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAdress = Console.ReadLine();
        string companyPhone = Console.ReadLine();
        string companyFax = Console.ReadLine();
        string companySite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int managerAge = int.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAdress);
        Console.WriteLine("Tel. {0}", companyPhone);
        if (companyFax == String.Empty)
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}", companyFax);
        }
        Console.WriteLine("Web site: {0}", companySite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})"
            , managerFirstName, managerLastName, managerAge, managerPhone);
    }
}