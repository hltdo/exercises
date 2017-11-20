using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Problem 9. Frequent number
Write a program that finds the most frequent number in an array.
Example:
input {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  | result	4 (5 times)
 */
class FrequentNumber
{
    static void Main(string[] args)
    {
        string input = "4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3"; //Console.ReadLine(); 
        string[] values = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int length = values.Length;
        int[] array = new int[length];

        //Parsing values to integers
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(values[i]);
        }

        int bestNum = 0;
        int mostOcuurence = 1;

        //Scan through the array
        for (int i = 0; i < length; i++)
        {
            int occurence = 1;
            int current = array[i];
            for (int j = i + 1; j < length; j++)
            {
                if (current == array[j])
                {
                    occurence++;
                }
                if (occurence > mostOcuurence)
                {
                    mostOcuurence = occurence;
                    bestNum = current;
                }
            }
        }
        Console.WriteLine("{0} ({1} times)", bestNum, mostOcuurence);
    }

}

