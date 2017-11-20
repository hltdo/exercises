using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 19.* Permutations of set
Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
example: N: 3	result: {1, 2, 3} 
                        {1, 3, 2} 
                        {2, 1, 3} 
                        {2, 3, 1} 
                        {3, 2, 1} 
                        {3, 1, 2}
         	    
*/

class PermutationsOfSet
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter a number to generate all the permutations of [1...N]: ");
        int number = 3; //int.Parse(Console.ReadLine());
        int[] arr = new int[number];

        for (int i = 0; i < number; i++)
        {
            arr[i] = i + 1;
        }

        //Call a method to generate all the permutations
        GeneratePermutations(arr,0);
    }

    static void GeneratePermutations<T>(T[] arr, int k)
    {
        if (k >= arr.Length)
        {
            Print(arr);
        }
        else
        {
            GeneratePermutations(arr, k + 1);
            for (int i = k + 1; i < arr.Length; i++)
            {
                Swap(ref arr[k], ref arr[i]);
                GeneratePermutations(arr, k + 1);
                Swap(ref arr[k], ref arr[i]);
            }
        }
    }

    static void Print<T>(T[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }

    static void Swap<T>(ref T first, ref T second)
    {
        T oldFirst = first;
        first = second;
        second = oldFirst;
    }
}
