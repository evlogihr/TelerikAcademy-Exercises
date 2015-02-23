using System;

namespace KaspochanNumbers
{
    class Program
    {
        static void Main()
        {
            // array of 256 elements
            ulong baseNum = 256;
            string[] arr = GenerateNumberArray(256);

            // read input
            ulong input = ulong.Parse(Console.ReadLine());

            // calculations
            string result = string.Empty;
            if (input == 0)
            {
                result = "A";
            }
            else
            {
                while (input > 0)
                {
                    ulong index = input % baseNum;
                    result = arr[index] + result;
                    input /= baseNum;
                }
            }

            // output
            Console.WriteLine(result);
        }

        private static string[] GenerateNumberArray(int numBase)
        {
            string[] arr = new string[numBase];
            for (int i = 0; i < numBase; i++)
            {
                if (i < 26) // solve for first 26
                {
                    arr[i] = string.Format("{0}",
                        (char)(i % 26 + 'A'));
                }
                else
                {
                    arr[i] = string.Format("{0}{1}",
                        (char)(i / 26 - 1 + 'a'),
                        (char)(i % 26 + 'A'));
                }
            }

            return arr;
        }
    }
}
