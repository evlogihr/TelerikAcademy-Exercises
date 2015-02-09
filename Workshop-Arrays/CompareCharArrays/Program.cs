using System;

class Program
{
    static void Main()
    {
        // read first array
        Console.Write("Enter first word: ");
        char[] firstWord = Console.ReadLine().ToCharArray();

        // read second array
        Console.Write("Enter second word: ");
        char[] secondWord = Console.ReadLine().ToCharArray();

        string lexicographicallyFirst = string.Join("", firstWord);
        int length = Math.Min(firstWord.Length, secondWord.Length);
        for (int i = 0; i < length; i++)
        {
            if (firstWord[i] > secondWord[i])
            {
                lexicographicallyFirst = string.Join("", secondWord);
                break;
            }
        }

        Console.WriteLine("Lexicographically first is: {0}", lexicographicallyFirst);
    }
}
