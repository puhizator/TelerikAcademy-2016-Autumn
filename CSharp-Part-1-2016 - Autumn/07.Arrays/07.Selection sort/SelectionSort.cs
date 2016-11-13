using System;

class SelectionSort
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        int[] arrayA = new int[n];

        for (int i = 0; i < n; i++)
        {
            arrayA[i] = int.Parse(Console.ReadLine());
        }

        //SORT
        //each element to 2nd last
        for (int current = 0; current < n - 1; current++)
        {
            //compare with each next element in the array
            //smaller element moves left
            for (int next = current + 1; next < n; next++)
            {
                if (arrayA[current] > arrayA[next])
                {
                    arrayA[current] ^= arrayA[next];    // a = a ^ b 
                    arrayA[next] ^= arrayA[current];    // b = (a ^ b) ^ b -> a
                    arrayA[current] ^= arrayA[next];    // a = (a ^ b) ^ a -> b
                }
            }
        }

        //output
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arrayA[i]);
        }
    }
}
