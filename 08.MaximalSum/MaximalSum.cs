using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 8. Maximal sum
Write a program that finds the sequence of maximal sum in given array.
 * Example:
 * input {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}    result {2, -1, 6, 4}
 */

class MaximalSum
{
    static void Main(string[] args)
    {
        string input = "2, 3, -6, -1, 2, -1, 6, 4, -8, 8"; //Console.ReadLine();
        //string input = "1, 2, 5, 10, -20, -1, 6, -4, -8, 8";
        //string input = "-15, 3, -6, 7, 10, 1, -4, -25, 8, 8";
        //string input = "0, 1, 6, 5, -2, -19, -1, 3, 1, 3";

        string[] values = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int length = values.Length;
        int[] array = new int[length];

        //Parsing values to integers
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(values[i]);
        }

        int bestSum = int.MinValue;
        int startIndex = 0;
        int endIndex = 0;

        //Scan array
        for (int i = 0; i < length; i++)
        {
            int currentNumber = array[i];
            for (int j = i + 1; j < length; j++)
            {
                currentNumber = currentNumber + array[j];
                if (currentNumber > bestSum)
                {
                    bestSum = currentNumber;
                    startIndex = i;
                    endIndex = j;
                }
            }
        }

        //print sequence with max sum
        Console.Write("{");
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i == endIndex)
            {
                Console.Write("{0}}}", array[i]);
            }
            else
            {
                Console.Write("{0}, ", array[i]);
            }
        }
        Console.WriteLine();
    }
}

