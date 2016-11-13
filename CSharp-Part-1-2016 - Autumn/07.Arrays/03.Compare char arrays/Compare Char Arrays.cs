using System; // write it again it's not working

class Program
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();
        char[] firstArray = firstInput.ToCharArray();
        char[] secondArray = secondInput.ToCharArray();
        int n = Math.Min(firstArray.Length, secondArray.Length);
        string result;

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine(">");
                break;
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("<");
                break;
            }
            else
            {
                result  = "=";
                continue;
            }
            
        }


    }
}