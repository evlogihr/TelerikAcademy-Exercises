using System;

class Program
{
    static void Main()
    {
        int[] arr = { 6, 5, 3, 1, 8, 7, 2, 9, 4 };

        arr = MergeSort(arr);
        Console.WriteLine(string.Join(", ", arr));
    }

    private static int[] MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }

        int middle = arr.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[arr.Length - middle];
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < middle)
            {
                left[i] = arr[i];
            }
            else
            {
                right[i - middle] = arr[i];
            }
        }

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

    private static int[] Merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int i, j;
        for (i = 0, j = 0; i < left.Length && j < right.Length; )
        {
            if (left[i] < right[j])
            {
                result[i + j] = left[i];
                i++;
            }
            else
            {
                result[i + j] = right[j];
                j++;
            }
        }

        for (; i < left.Length; i++)
        {
            result[i + j] = left[i];
        }

        for (; j < right.Length; j++)
        {
            result[i + j] = right[j];
        }

        return result;
    }
}

