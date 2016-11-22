using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int sum = int.MinValue;
        int bestSum = int.MinValue;


        int[,] matrix = new int[n, m];

        for (int row = 0; row < n; row++)
        {
            input = Console.ReadLine().Split();
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = int.Parse(input[col]);
            }
        }

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    sum = 0;
                }
            }
        }
        Console.WriteLine(bestSum);
    }
}