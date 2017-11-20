using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 13.* Merge sort
Write a program that sorts an array of integers using the Merge sort algorithm.*/

class MergeSort
{
    static void Main(string[] args)
    {
        int[] array = { 4, -7, 3, 10, 9, 5, 1, -9, 7 };
        array = MergeSorting(array);
        Console.WriteLine(String.Join(", ", array));
    }

    private static int[] MergeSorting(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }
        int middle = array.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[array.Length - middle];

        for (int i = 0; i < array.Length; i++)
        {
            if (i < middle)
            {
                left[i] = array[i];
            }
            else
            {
                right[i - middle] = array[i];
            }
        }
        left = MergeSorting(left);
        right = MergeSorting(right);

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

