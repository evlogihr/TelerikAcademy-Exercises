using System;
using System.Linq;

namespace DancingMove
{
    class Program
    {
        static void Main()
        {
            int[] floor = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string line;
            int i = 0;
            long sum = 0;
            int rounds = 0;
            while ((line = Console.ReadLine()) != "stop")
            {
                string[] split = line.Split(' ');
                int count = int.Parse(split[0]);
                int dir = split[1] == "right" ? 1 : -1;
                int step = int.Parse(split[2]) * dir;

                for (int c = 0; c < count; c++)
                {
                    i += step;
                    while (i < 0)
                    {
                        i += floor.Length;
                    }

                    while (i > floor.Length - 1)
                    {
                        i -= floor.Length;
                    }

                    sum += floor[i];
                }

                 rounds++;
            }

            Console.WriteLine("{0:f1}", sum / (double)rounds);
        }
    }
}
