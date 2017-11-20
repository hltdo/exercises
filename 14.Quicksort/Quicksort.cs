using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 14. Quick sort
Write a program that sorts an array of integers using the Quick sort algorithm.
 */

class Quicksort
{
    static void Main()
    {
        //generate a collection
        //int[] numbers = Enumerable.Range(-10, 20).ToArray();
        int length = 5; //int.Parse(Console.ReadLine());
        int[] numbers = new int[length];

        // initialize 
        for (int i = 0; i < length; i++)
        {
            if ((i & 1) == 0)
            {
                numbers[i] = i;
            }
            else
            {
                numbers[i] = -i;
            }
        }

        Console.WriteLine("{0} - Unsorted array", String.Join(" ", numbers));

        QuickSorting(numbers, 0, length-1);

        Console.WriteLine("{0} - Sorted array", String.Join(" ", numbers));
    }
    public static void QuickSorting(int[] input, int low, int high)
    {
        int pivot = 0;
        if (low < high)
        {
            pivot = Partitioning(input, low, high);
            QuickSorting(input, low, pivot - 1);
            QuickSorting(input, pivot + 1, high);
        }
    }

    private static int Partitioning(int[] input, int low, int high)
    {
        int pivot = input[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (input[j] <= pivot)
            {
                i++;
                Swaping(input, i, j);
            }
        }
        Swaping(input, i + 1, high);
        return i + 1;
    }

    private static void Swaping(int[] ar, int a, int b)
    {
        int temp;
        temp = ar[a];
        ar[a] = ar[b];
        ar[b] = temp;
    }
}

