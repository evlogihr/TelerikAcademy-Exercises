using System;

namespace DarankulakNumbers
{
    class Program
    {
        static void Main()
        {
            ulong baseNum = 168;

            // read input
            string input = Console.ReadLine();

            // logic
            ulong num = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currentNum = GetVCurrentNumber(input, ref i);

                // find current number
                num *= baseNum;
                if (currentNum.Length == 1)
                {
                    num += (ulong)(currentNum[0] - 'A');
                }
                else // if length == 2
                {
                    num += (ulong)((currentNum[0] - 'a' + 1) * 26);
                    num += (ulong)(currentNum[1] - 'A');
                }
            }

            // output
            Console.WriteLine(num);
        }

        private static string GetVCurrentNumber(string input, ref int i)
        {
            char letter = input[i];
            string currentNum = string.Empty;
            if ('a' <= letter && letter <= 'z')
            {
                currentNum = string.Format("{0}{1}", input[i], input[i + 1]);
                i++;
            }
            else
            {
                currentNum = string.Format("{0}", letter);
            }
            return currentNum;
        }
    }
}
