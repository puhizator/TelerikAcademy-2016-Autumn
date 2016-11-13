using System;

class Program
{

    //This function is a Recursion. The Recursion calls itself with different parameters inside the body or it exits from the bottom,
    // in this case " return result;" . That ensures exiting the function when needed.
    // For understanding it better read this https://www.dotnetperls.com/recursion.
    static long Recursion(long firstNumber, long secondNumber, long result)
    {
        if (firstNumber > secondNumber)
        {
            return result;
        }
        for (int i = 2; i <= firstNumber; i += 2)
        {
            if (firstNumber % i == 0)
            {
                result += i;
            }
        }

        return Recursion(firstNumber + 1, secondNumber, result);
    }

    static void Main()
    {
        long firstInput = long.Parse(Console.ReadLine());
        long secondInput = long.Parse(Console.ReadLine());
        long sum = 0;
        // You can think of the Recursion method as a long type variable, because when the operationions inside the body of the 
        //function are done, the only thing you have as a result is a number of type long.
        Console.WriteLine(Recursion(firstInput, secondInput, sum));
    }
}