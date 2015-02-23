using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleJustification
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();
            string[] line;
            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < line.Length; j++)
                {
                    words.Add(line[j]);
                }
            }

            StringBuilder result = new StringBuilder();
            string currentLine = string.Empty;
            int currnetLineWordsCount = 0;
            int spacesToAdd;
            int indexToAddSpace;
            for (int i = 0; i < words.Count; i++)
            {
                if (currentLine.Length + words[i].Length <= width)
                {
                    currentLine += string.Format("{0} ", words[i]);
                    currnetLineWordsCount++;
                    continue;
                }

                currentLine = AddLine(width, currentLine, currnetLineWordsCount, out spacesToAdd, out indexToAddSpace);

                result.AppendLine(currentLine);
                currentLine = string.Format("{0} ", words[i]);
                currnetLineWordsCount = 1;
            }


            currentLine = AddLine(width, currentLine, currnetLineWordsCount, out spacesToAdd, out indexToAddSpace);
            result.Append(currentLine);

            Console.WriteLine(result);
        }

        private static string AddLine(int width, string currentLine, int currnetLineWordsCount, out int spacesToAdd, out int indexToAddSpace)
        {
            currentLine = currentLine.Trim(); // trim last space
            spacesToAdd = width - currentLine.Length;
            indexToAddSpace = currentLine.IndexOf(" ");
            if (currnetLineWordsCount != 1)
            {
                for (int j = 0; j < currnetLineWordsCount && spacesToAdd > 0; j++)
                {
                    int spaces = (int)Math.Ceiling(spacesToAdd / (double)(currnetLineWordsCount - j - 1));
                    currentLine = currentLine.Insert(indexToAddSpace, new string(' ', spaces));
                    indexToAddSpace = currentLine.IndexOf(' ', indexToAddSpace + spaces + 1);
                    spacesToAdd -= spaces;
                }
            }
            return currentLine;
        }
    }
}
