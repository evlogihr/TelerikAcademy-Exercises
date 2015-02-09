using System;

class Program
{
    static void Main()
    {
        int n = 3;
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }

        Permutation(arr, 0);
    }

    private static void Permutation(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            Console.WriteLine(string.Join(", ", arr));
            return;
        }

        for (int i = index; i < arr.Length; i++)
        {
            Swap(arr, i, index);
            Permutation(arr, index + 1);
            Swap(arr, i, index);
        }
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}