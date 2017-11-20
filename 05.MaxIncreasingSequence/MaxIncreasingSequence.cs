using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
Example:	
input {3, 2, 3, 4, 2, 2, 4} 	result {2, 3, 4}
*/
class MaxIncreasingSequence
{
    static void Main()
    {
        string input = "3, 2, 3, 4, 2, 2, 4"; //Console.ReadLine(); 
        string[] values = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int length = values.Length;
        int[] array = new int[length];

        //Parsing values to integers
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(values[i]);
        }
        
        int start = 0;
        int bestStart = 0;
        int len = 1;
        int bestLength = 1;
        int endIndex = 0;

        //Scan array
        for (int i = 0; i < length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                len++;
            }
            else
            {
                len = 1;
            }
            if (len > bestLength)
            {
                endIndex = i + 1;
                start = endIndex - len + 1;
                bestLength = len;
                bestStart = start;
            }
        }

        //Print longest increasing sequence
        Console.Write("Longest increasing sequence: {");

        for (int i = bestStart; i <= endIndex; i++)
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

