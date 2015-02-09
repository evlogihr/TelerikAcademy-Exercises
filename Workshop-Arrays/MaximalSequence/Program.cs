using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // if you want to test with other string uncoment
        string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1";
        //string input = "2, 1, 1, 1, 2, 3, 3, 2, 2, 2, 1";
        //string input = "2, 1, 1, 1, 1, 2, 3, 3, 2, 2, 2, 1";
        //string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 2, 2, 1";
        //string input = "2, 2, 2, 2, 2, 2, 1, 1, 2, 3, 3, 2, 2, 2, 1";
        //string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1";
        //string input = "1, 2, 3, 4, 5, 6";

        string[] numsStr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] nums = new int[numsStr.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(numsStr[i]);
        }

        int[] numbers = input
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n)).ToArray();

        int[] hardcodedNums = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

        int currentNum, maxNum = nums[0];
        int currentCount, maxCount = 0;
        for (int i = 0; i < nums.Length; )
        {
            currentNum = nums[i];
            currentCount = 0;
            for (; i < nums.Length; i++)
            {
                if (currentNum != nums[i])
                {
                    break;
                }

                currentCount++;
            }

            if (maxCount <= currentCount)
            {
                maxCount = currentCount;
                maxNum = currentNum;
            }
        }

        for (int i = 0; i < maxCount; i++)
        {
            Console.Write(maxNum);
            if (i != maxCount - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
