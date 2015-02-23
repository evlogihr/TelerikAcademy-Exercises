using System;
using System.Linq;

namespace Slides
{
    class Program
    {
        static void Main()
        {
            // read dimensions
            string[] line = Console.ReadLine().Split(' ');
            int cuboidWidth = int.Parse(line[0]);
            int cuboidHeigth = int.Parse(line[1]);
            int cuboidDepth = int.Parse(line[2]);

            // read cuboid
            string[, ,] cuboid = new string[cuboidWidth, cuboidHeigth, cuboidDepth];
            for (int h = 0; h < cuboidHeigth; h++)
            {
                string[] row = Console.ReadLine().Split('|');
                for (int d = 0; d < cuboidDepth; d++)
                {
                    string[] cubes = row[d].Trim().Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int w = 0; w < cuboidWidth; w++)
                    {
                        string cube = cubes[w];
                        cuboid[w, h, d] = cube;
                    }
                }
            }

            // read ball
            line = Console.ReadLine().Split(' ');
            int ballWidth = 0;
            int ballHeight = 0;
            int ballDepth = 0;

            // execute ball falling
            int nextWidth = int.Parse(line[0]);
            int nextHeight = 0;
            int nextDepth = int.Parse(line[1]);
            bool canDropo = true;
            string currentCube = "";
            while (canDropo)
            {
                if (nextHeight == cuboidHeigth)
                {
                    break;
                }

                if (0 > nextWidth || nextWidth > cuboidWidth - 1 ||
                    0 > nextDepth || nextDepth > cuboidDepth - 1)
                {
                    canDropo = false;
                    break;
                }

                ballWidth = nextWidth;
                ballHeight = nextHeight;
                ballDepth = nextDepth;

                // read current cube
                currentCube = cuboid[nextWidth, nextHeight, nextDepth];
                // execute current cube commnad
                // S X; T 1 1; B; E
                char command = currentCube[0];
                switch (command)
                {
                    case 'B': canDropo = false; break;
                    case 'E': nextHeight++; break;
                    case 'T': // "T 1 1"
                        int[] coord = currentCube.Substring(2).Split(' ')
                            .Select(x => int.Parse(x)).ToArray();
                        nextWidth = coord[0];
                        nextDepth = coord[1];
                        break;
                    case 'S': // S L; R; F; B; FL FL..
                        nextHeight++;
                        string dir = currentCube.Substring(2);
                        switch (dir)
                        {
                            case "L": nextWidth--; break;
                            case "R": nextWidth++; break;
                            case "F": nextDepth--; break;
                            case "B": nextDepth++; break;
                            case "FL": nextWidth--; nextDepth--; break;
                            case "FR": nextWidth++; nextDepth--; break;
                            case "BL": nextWidth--; nextDepth++; break;
                            case "BR": nextWidth++; nextDepth++; break;
                        }
                        break;
                }

            }

            // output
            Console.WriteLine(canDropo ? "Yes" : "No");
            Console.WriteLine("{0} {1} {2}", ballWidth, ballHeight, ballDepth);
        }
    }
}