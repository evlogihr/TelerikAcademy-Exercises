using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 1, 2, 6, 8, 3, 4 };

        int minValue;
        int minIndex = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            minValue = int.MaxValue;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (minValue > arr[j])
                {
                    minValue = arr[j];
                    minIndex = j;
                }
            }

            int temp = arr[i];
            arr[i] = minValue;
            arr[minIndex] = temp;
        }

        Console.WriteLine(string.Join(", ", arr));
    }
}