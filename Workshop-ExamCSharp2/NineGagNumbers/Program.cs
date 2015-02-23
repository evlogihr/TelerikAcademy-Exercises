using System;
using System.Text;

namespace NineGagNumbers
{
    class Program
    {
        static void Main()
        {
            string input = "***!!!";// Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            ulong num = 0;
            ulong pow = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);

                switch (sb.ToString())
                {
                    case "-!":      num+= (ulong)Math.Pow(0, pow); pow++; sb.Clear(); break;              
                    case "**":      num+= (ulong)Math.Pow(1, pow); pow++; sb.Clear(); break;              
                    case "!!!":     num+= (ulong)Math.Pow(2, pow); pow++; sb.Clear(); break;              
                    case "&&":      num+= (ulong)Math.Pow(3, pow); pow++; sb.Clear(); break;              
                    case "&-":      num+= (ulong)Math.Pow(4, pow); pow++; sb.Clear(); break;              
                    case "!-":      num+= (ulong)Math.Pow(5, pow); pow++; sb.Clear(); break;              
                    case "*!!!":    num+= (ulong)Math.Pow(6, pow); pow++; sb.Clear(); break;              
                    case "&*!":     num+= (ulong)Math.Pow(7, pow); pow++; sb.Clear(); break;              
                    case "!!**!-":  num+= (ulong)Math.Pow(8, pow); pow++; sb.Clear(); break;
                    default: break;
                }
            }
        }
    }
}
