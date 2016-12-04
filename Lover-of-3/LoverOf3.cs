using System;
using System.Linq;

namespace LoverOf3
{
    class Program
    {
        static void Main()
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool[,] matrix = new bool[sizes[0], sizes[1]];
            int n = int.Parse(Console.ReadLine());

            int[] pos = { matrix.GetLength(0) - 1, 0 };
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                string[] split = Console.ReadLine().Split(' ');
                int steps = int.Parse(split[1]);
                int[] dir = new int[2];
                switch (split[0])
                {
                    case "RU":
                    case "UR": dir = new int[] { -1, 1 }; break;
                    case "LU":
                    case "UL": dir = new int[] { -1, -1 }; break;
                    case "DL":
                    case "LD": dir = new int[] { 1, -1 }; break;
                    case "RD":
                    case "DR": dir = new int[] { 1, 1 }; break;
                }

                for (int j = 1; j < steps; j++)
                {
                    if (pos[0] + dir[0] >= 0 && pos[0] + dir[0] < matrix.GetLength(0) &&
                        pos[1] + dir[1] >= 0 && pos[1] + dir[1] < matrix.GetLength(1))
                    {
                        pos[0] += dir[0]; // row
                        pos[1] += dir[1]; // col

                        sum += GetValue(matrix, pos[0], pos[1]);
                    }
                }
            }

            Console.WriteLine(sum);
        }

        private static long GetValue(bool[,] matrix, int row, int col)
        {
            long result = 0;
            if (!matrix[row, col])
            {
                result = 3 * ((matrix.GetLength(0) - 1 - row) + (col));
                matrix[row, col] = true;
            }

            return result;
        }
    }
}
