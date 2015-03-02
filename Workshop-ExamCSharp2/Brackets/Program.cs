using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brackets
{
    class Program
    {
        static void Main()
        {
#if DEBUG
            Console.SetIn(new System.IO.StreamReader("../../test.in.txt"));
            Console.SetOut(new System.IO.StreamWriter("../../test.out.txt"));
#endif

            int n = int.Parse(Console.ReadLine());
            string indent = Console.ReadLine();
            string[] lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            char prevCh = new char();
            int indentCount = 0;
            List<string> code = new List<string>();
            for (int i = 0; i < n; i++)
            {
                StringBuilder line = new StringBuilder();
                string lineIndent = GetLineIndent(indent, indentCount);
                foreach (char ch in lines[i])
                {
                    if (ch == '{')
                    {
                        AddLine(line, lineIndent, code);
                        line.Clear();
                        code.Add(string.Format("{0}{1}", lineIndent, ch));
                        indentCount++;
                        lineIndent = GetLineIndent(indent, indentCount);
                    }
                    else if (ch == '}')
                    {
                        AddLine(line, lineIndent, code);
                        line.Clear();
                        indentCount--;
                        lineIndent = GetLineIndent(indent, indentCount);
                        code.Add(string.Format("{0}{1}", lineIndent, ch));
                    }
                    else
                    {
                        if (!(ch == ' ' && prevCh == ' '))
                            line.Append(ch);
                    }

                    prevCh = ch;
                }

                AddLine(line, lineIndent, code);
            }

            foreach (string line in code)
            {
                Console.WriteLine(line);
            }
        }

        private static void AddLine(StringBuilder line, string lineIndent, List<string> code)
        {
            if (line.ToString().TrimStart().Length > 0)
                code.Add(string.Format("{0}{1}", lineIndent, line.ToString().TrimStart()));
        }

        private static void AddLine(List<string> code, StringBuilder line, string lineIndent)
        {

        }

        private static string GetLineIndent(string indent, int indentCount)
        {
            string lineIndent = "";
            for (int i = 0; i < indentCount; i++)
            {
                lineIndent += indent;
            }

            return lineIndent;
        }

    }
}
