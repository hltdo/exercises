using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Problem 4. Maximal sequence
Write a program that finds the maximal sequence of equal elements in an array.
 * Example: input {2, 1, 1, 2, 3, 3, 2, 2, 2, 1},	result {2, 2, 2}
 */

class MaximalSequence
{
    static void Main()
    {
        string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1"; //Console.ReadLine(); 
        string [] values = input.Split(new char [] {',', ' '}, StringSplitOptions.RemoveEmptyEntries );
        int length = values.Length;
        int[] array = new int [length];
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(values[i]);
        }

        int bestStart = 0;
        int start = 0;
        int bestLen = 1;
        int len = 1;

        //Scan array
        for (int i = 0; i < length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                start = array[i];
                len++;
            }
            else
            {
                len = 1;
            }
            if (bestLen < len)
            {
                bestLen = len;
                bestStart = start;
            }
        }
        Console.WriteLine("Number {0} is repeated consecutively {1} times", bestStart, bestLen);

        //Print max sequence
        Console.Write("{");
        for (int i = 0; i < bestLen - 1; i++)
        {
            Console.Write("{0}, ", bestStart);
        }
        Console.Write(bestStart + "}");
        Console.WriteLine();
    }
}

