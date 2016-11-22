using System;

class Program
{
    static void Main()
    {
        string[] matrixLength = Console.ReadLine().Split(); //read first line input as a string array and split by whitespace
        int n = int.Parse(matrixLength[0]); // store in "n" the first number in array and cast it to int
        int m = int.Parse(matrixLength[1]); // store in "m" the second number in array and cast it to int

        // initialize the matrix size (could be string, because it's written in the description)
        string[,] matrix = new string[n, m];

        // read the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] lines = Console.ReadLine().Split();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = lines[col];
            }
        }
        int maxCounter = 1;
        int counter = 1;

        // check rows
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            counter = 1;
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }
        counter = 1;

        // check cols
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            counter = 1;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }
        counter = 1;

        //check diagonal left to right
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            counter = 1;
            int temp = row;
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    counter++;
                    row++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }

                    if ((row + 1 == matrix.GetLength(0)) || (col + 1 == matrix.GetLength(1))) //check if inside the frame
                    {
                        row = temp; //back the first value of row, before he start of the sequence
                        counter = 1;
                    }
                }
                else
                {
                    col = col - counter + 1; // every counter increase, skip check of col
                                             // back the first value of col, before we start of the sequence
                    counter = 1;
                    row = temp;
                }
            }
        }

        // check diagonal from right to left
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            counter = 1;
            int temp = row;
            for (int col = matrix.GetLength(1) - 1; col > 0 && row + 1 < matrix.GetLength(0); col--)
            {
                if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    counter++;
                    row++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }

                    if ((row + 1 == matrix.GetLength(0)) || (col - 1 == 0))
                    {
                        row = temp;
                        counter = 1;
                    }
                }
                else
                {
                    col = col + counter - 1;
                    counter = 1;
                    row = temp;
                }
            }
        }
        Console.WriteLine(maxCounter);
    }
}