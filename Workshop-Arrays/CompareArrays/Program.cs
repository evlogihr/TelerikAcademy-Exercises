using System;

class Program
{
    static void Main()
    {
        // read first array
        Console.Write("Enter length of first array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter first array: ");
        int[] firstArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        // read second array
        Console.Write("Enter length of second array: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter second array: ");
        int[] secondArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = true;
        if (firstArr.Length != secondArr.Length)
        {
            areEqual = false;            
        }
        else
        {
            for (int i = 0; i < firstArr.Length && areEqual; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    areEqual = false;
                }
            }
        }

        Console.WriteLine("Are the arrays equal: {0}", areEqual);
    }
}