using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 16.* Subset with sum S
We are given an array of integers and a number S.
Write a program to find if there exists a subset of the elements of the array that has a sum S.
Example:
|input array	             | S	  |result
|2, 1, 2, 4, 3, 5, 2, 6	     |14	  |yes
 */

class SubsetWithSum
{
    static void Main()
    {
        //Console.WriteLine("Enter numbers separated by comma and single space: ");
        string input = "2, 1, 2, 4, 3, 5, 2, 6"; //Console.ReadLine(); 
        //Console.WriteLine("Enter the sum you are looking for: ");
        int wantedSum = -14; //int.Parse(Console.ReadLine());

        string[] values = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int length = values.Length;

        //Parsing values from string to int
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(values[i]);
        }
        GeneratePossibleCombinations(array, wantedSum);
    }

    private static void GeneratePossibleCombinations(int[] array, int wantedSum)
    {
        bool thereIsSum = false;
        bool done = false;
        for (int i = 0; i < (2 << array.Length) - 1 && !done; i++)
        {
            int sum = 0;

            for (int j = 0; j < array.Length && !done; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sum += array[j];
                }

                if (sum == wantedSum)
                {
                    thereIsSum = true;
                    done = true;
                }
            }
        }
        Console.WriteLine("Sum {0} in the array ---> {1}", wantedSum, thereIsSum ? "Yes" : "No");
    }
}

