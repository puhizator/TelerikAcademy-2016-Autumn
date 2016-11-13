using System;

class Speeds
{
    static void Main()
    {
        //This solution is not very optimal...it has some useless stuff and it is alot more complicated than it should be..i would suggest checking out author's solution OR
        //Iliangogo's solution from this thread : http://telerikacademy.com/Forum/Questions/200670/Exam-Fundamentals-26-April-2016-Morning-Speed#forum-post-200710
        //The whole array thing is useless in this case
        uint carCount = uint.Parse(Console.ReadLine());
        int[] carsSpeed = new int[carCount];
        int[] carsDefaultSpeed = new int[carCount];

        for (int i = 0; i < carCount; i++)
        {
            carsSpeed[i] = int.Parse(Console.ReadLine());
            carsDefaultSpeed[i] = carsSpeed[i];
            if (i == 0)
            {
                continue;
            }
            if (carsSpeed[i] > carsSpeed[i - 1])
            {
                carsSpeed[i] = carsSpeed[i - 1];
            }
        }
        int currentGroup = 1;
        int bestGroup = 1;
        int bestIndex = 0;
        int bestSpeed = 0;
        int comparingSpeeds = 0;
        for (int i = 0; i < carCount - 1; i++)
        {
            while (carsSpeed[i] == carsSpeed[i + 1] && carsDefaultSpeed[i + 1] != carsSpeed[i + 1])
            {
                currentGroup++;
                i++;
                if (i == carCount - 1)
                    break;
            }
            if (currentGroup > bestGroup)
            {
                bestSpeed = 0;
                bestGroup = currentGroup;
                currentGroup = 1;
                bestIndex = i;
                for (int m = i, n = 0; n < bestGroup; m--, n++)
                {
                    bestSpeed += carsDefaultSpeed[m];
                }
            }
            else if (currentGroup == bestGroup)
            {
                for (int t = i, n = 0; n < bestGroup; t--, n++)
                {
                    comparingSpeeds += carsDefaultSpeed[t];
                }
                if (comparingSpeeds > bestSpeed)
                {
                    bestSpeed = comparingSpeeds;
                    bestIndex = i;
                    bestGroup = currentGroup;
                }
            }
            currentGroup = 1;
            comparingSpeeds = 0;
        }
        Console.WriteLine(bestSpeed);
    }
}