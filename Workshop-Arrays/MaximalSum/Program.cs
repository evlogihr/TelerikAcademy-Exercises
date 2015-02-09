using System;

namespace MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] nums = { 2, 3, -6, -1, 2, -3, 6, 4, -8, 8 };

            int maxSum = 0, currentSum = 0;
            int startIndex = -1, currentStart = -1;
            int maxLength = 0, currentLenght = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                //currentStart = i;
                //currentLenght = 1;
                //currentSum = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    currentSum += nums[j];
                    currentLenght++;

                    if (maxSum < currentSum) // TODO: fix check to get correct result
                    {
                        maxSum = currentSum;
                        currentSum = 0;
                        startIndex = i;
                        maxLength = currentLenght;
                        currentLenght = 1;
                    }
                    else
                    {
                        currentSum = 0;
                        currentLenght = 1;
                    }
                }
            }

            // print result
            for (int i = startIndex; i < startIndex + maxLength; i++)
            {
                Console.Write("{0} + ", nums[i]);
            }
            Console.WriteLine(" = {0}", maxSum);
        }
    }
}
