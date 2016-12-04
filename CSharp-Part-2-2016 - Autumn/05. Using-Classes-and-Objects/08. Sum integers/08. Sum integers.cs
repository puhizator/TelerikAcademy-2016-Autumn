using System;
using System.Linq;

namespace _08.Sum_integers
{
    class Program
    {
        static void Main()
        {
            int[] numArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                sum += numArray[i];
            }

            //foreach (var num in numArray)
            //{
            //    sum += num;
            //}

            Console.WriteLine(sum);
        }
    }
}
