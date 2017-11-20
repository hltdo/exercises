using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 17.* Subset K with sum S
Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
Find in the array a subset of K elements that have sum S or indicate about its absence.
 */

class SubsetKWithSumS
{
    static bool done = false;
    static void Main()
    {
        Console.WriteLine("Enter N (number of elements in the array):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K (number of elements in the subset of the array): ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter S (sum you are looking for):");
        int s = int.Parse(Console.ReadLine());

        //Initialize and fill in array
        int[] arr = new int[n];
        Console.WriteLine("Elements in the array: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        GeneratePossibleCombinations(arr, n, k, s);
    }

    private static void GeneratePossibleCombinations(int[] arr, int n, int k, int s)
    {
        for (int i = 0; i < (2 << n) - 1 && !done; i++)
        {
            int sum = 0;
            int count = 0;
            string temp = "";

            for (int j = 0; j < n && !done; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sum += arr[j];
                    count++; // counts the number of elements
                    temp += arr[j] + ",";
                }

                if (count == k && sum == s) // if we find the sum S in K elements -> stop the program 
                                            // and print the elements that make up the wanted sum
                {
                    Console.WriteLine("Sum {0} found in the elements: ({1})",s,temp.Trim(','));
                    done = true;
                }
            }
        }
        if (!done)
        {
            Console.WriteLine("No sum {0} within the array.",s);
        }
    }
}

