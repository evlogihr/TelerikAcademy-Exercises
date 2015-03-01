using System;
using System.IO;
using System.Linq;
using System.Text;

namespace FTML
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                text.AppendLine(Console.ReadLine());
            }

            string line = text.ToString().Trim();
            int closeTagBeg = line.IndexOf("</");
            while (closeTagBeg != -1)
            {
                int closeTagEnd = line.IndexOf(">", closeTagBeg + 1);
                string tagName = line.Substring(closeTagBeg + 2, closeTagEnd - closeTagBeg - 2);

                int openTagBeg = line.LastIndexOf(string.Format("<{0}>", tagName), closeTagBeg);
                int openTagEnd = openTagBeg + tagName.Length + 2;
                string content = line.Substring(openTagEnd, closeTagBeg - openTagEnd);

                switch (tagName)
                {
                    case "rev": content = Reverse(content); break;
                    case "toggle": content = Toggle(content); break;
                    case "lower": content = content.ToLower(); break;
                    case "upper": content = content.ToUpper(); break;
                    case "del": content = ""; break;
                }

                line = line.Remove(openTagBeg, closeTagEnd - openTagBeg + 1);
                line = line.Insert(openTagBeg, content);

                closeTagBeg = line.IndexOf("</");
            }

            Console.WriteLine(line);
        }

        private static string Toggle(string content)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in content)
            {
                if (Char.IsLetter(ch))
                {
                    if (Char.IsUpper(ch))
                    {
                        sb.Append(Char.ToLower(ch));
                    }
                    else
                    {
                        sb.Append(Char.ToUpper(ch));
                    }
                }
                else
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString();
        }

        private static string Reverse(string content)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = content.Length - 1; i >= 0; i--)
            {
                if (content[i] != '\r')
                {
                    sb.Append(content[i]);
                }
            }

            return sb.ToString();
        }
    }
}
