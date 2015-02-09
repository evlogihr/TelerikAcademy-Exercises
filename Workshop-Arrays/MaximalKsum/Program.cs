using System;

class Program
{
    static void Main()
    {
        int k = 4; // int.Parse(Console.ReadLine());
        int n = 7; // int.Parse(Console.ReadLine());
        int[] arr = { 5, 1, 2, 6, 8, 3, 4 }; // TODO: read array from console
        Array.Sort(arr);

        int result = 0;
        for (int i = arr.Length - 1; i > arr.Length - 1 - k; i--)
        {
            result += arr[i];
            Console.Write(arr[i]);
            if (i == arr.Length - k)
            {
                Console.Write(" = ");
            }
            else
            {
                Console.Write(" + ");
            }
        }
        Console.WriteLine(result);
    }
}