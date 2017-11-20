using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 6. Maximal K sum
Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */
class MaxKSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter N - length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K - number of elements with greatest sum: ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter {0} elements to fill in the array: ", n);
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        // sort the array in order to put the biggest numbers in the end
        Array.Sort(array);

        //Print last K numbers
        Console.Write("These K elements have max sum: {");
        for (int i = n - k; i < n; i++)
        {
            if (i == n - 1)
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

