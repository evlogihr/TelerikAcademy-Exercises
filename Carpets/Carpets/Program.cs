using System;

class Program
{
    static void Main()
    {
        // input
        int n = int.Parse(Console.ReadLine());

        // logic
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                bool isInQuadrantOne = c < n / 2 && r < n / 2;
                bool isInQuadrantTwo = c >= n / 2 && r < n / 2;
                bool isInQuadrantThree = c < n / 2 && r >= n / 2;
                bool isInQuadrantFour = c >= n / 2 && r >= n / 2;

                bool isCoreOne = r + c - n / 2 + 1 <= 0;
                bool isCoreTwo = r - c + n / 2 <= 0;
                bool isCoreThree = c - r + n / 2 <= 0;
                bool isCoreFour = r + c - 3 * n / 2 + 1 >= 0;

                if ((isCoreOne && isInQuadrantOne) ||
                    (isCoreFour && isInQuadrantFour))
                {
                    if ((r + c - n / 2 + 1) % 2 == 0)
                    {
                        Console.Write('/');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                else if ((isCoreTwo && isInQuadrantTwo) ||
                    (isCoreThree && isInQuadrantThree))
                {
                    if ((r - c + n / 2) % 2 == 0)
                    {
                        Console.Write('\\');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                else
                {
                    Console.Write('.');
                }
            }

            Console.WriteLine();
        }
    }
}