using System;
using System.Collections.Generic;
using System.Linq;

namespace KukataIsDancing
{
    class Program
    {
        static void Main()
        {
            // read input
            int n = int.Parse(Console.ReadLine());

            string[,] floor = { { "RED", "BLUE", "RED" },
                               { "BLUE", "GREEN", "BLUE" },
                                { "RED", "BLUE", "RED" } };
            int[][] dirs = { new int[]{ 0, 1 },   // right
                             new int[]{ -1, 0 },  // up
                             new int[]{ 0, -1 },  // left
                             new int[]{ 1, 0 } }; // down

            for (int i = 0; i < n; i++)
            {
                string dance = Console.ReadLine();
                int[] pos = { 1, 1 };
                int dirInd = 0;
                int[] dir = dirs[dirInd];

                foreach (char step in dance)
                {
                    switch (step)
                    {
                        case 'W':
                            pos = Walk(pos, dir);
                            RotateFloor(floor, pos);
                            break;
                        case 'R':
                            dirInd = TurnRight(dirs, dirInd);
                            dir = dirs[dirInd]; // change current directoin
                            break;
                        case 'L':
                            dirInd = TurnLeft(dirs, dirInd);
                            dir = dirs[dirInd]; // change current directoin
                            break;
                    }
                }

                // print result for current dance
                int curretnRow = pos[0];
                int currentCol = pos[1];
                string result = floor[curretnRow, currentCol];
                Console.WriteLine(result);
            }
        }

        private static void RotateFloor(string[,] floor, int[] pos)
        {
            for (int j = 0; j < pos.Length; j++)
            {
                // check if out of dance floor
                if (pos[j] >= floor.GetLength(j))
                {
                    pos[j] = 0;
                }
                else if (pos[j] < 0)
                {
                    pos[j] = floor.GetLength(j) - 1;
                }
            }
        }

        private static int[] Walk(int[] pos, int[] dir)
        {
            for (int i = 0; i < pos.GetLength(0); i++)
            {
                pos[i] += dir[i];
            }

            return pos;
        }

        private static int TurnLeft(int[][] dirs, int dirInd)
        {
            dirInd += 1;
            if (dirInd >= dirs.GetLength(0))
            {
                dirInd = 0;
            }

            return dirInd;
        }

        private static int TurnRight(int[][] dirs, int dirInd)
        {
            dirInd -= 1;
            if (dirInd < 0)
            {
                dirInd = dirs.GetLength(0) - 1;
            }

            return dirInd;
        }
    }
}
