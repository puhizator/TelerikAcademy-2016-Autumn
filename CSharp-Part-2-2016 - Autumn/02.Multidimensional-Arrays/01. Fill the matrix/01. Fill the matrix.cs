using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char m = char.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int number = 1;


        if (m == 'a')
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
        }
        else if (m == 'b')
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                }
            }
        }
        else if (m == 'c')
        {
            for (int i = 0; i < n; i++)
            {
                int row = n - 1 - i;
                int col = 0;

                for (int j = 0; j <= i; j++)
                {
                    matrix[row, col] = number;
                    matrix[n - 1 - row, n - 1 - col] = n * n + 1 - number++;
                    col++; row++;
                }

            }
        }
        else
        {
            for (int depth = 0; depth <= (n / 2); depth++)
            {
                for (int down = depth; down <= n - depth - 1; down++, number++)
                {
                    matrix[down, depth] = number;
                }
                for (int right = depth + 1; right <= n - depth - 1; right++, number++)
                {
                    matrix[(n - depth - 1), right] = number;
                }
                for (int up = n - depth - 2; up > depth; up--, number++)
                {
                    matrix[up, (n - depth - 1)] = number;
                }
                for (int left = n - depth - 1; left > depth; left--, number++)
                {
                    if (matrix[depth, left] == 0)
                    {
                        matrix[depth, left] = number;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col]);
                    if (col + 1 == matrix.GetLength(0))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }    
}