using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 21.* Combinations of set
Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
Example:    N	K	result
            5	2	{1, 2} 
                    {1, 3} 
                    {1, 4} 
                    {1, 5} 
                    {2, 3} 
                    {2, 4} 
                    {2, 5} 
                    {3, 4} 
                    {3, 5} 
                    {4, 5}
 */

class CombinationsOfSet
{
    const int n = 5; //int.Parse(Console.ReadLine());
    const int k = 2; //int.Parse(Console.ReadLine());
    static int[] numbers = new int[n];
	
    static int[] arr = new int[k];

    static void Main()
    {
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }
        GenerateCombinationsNoRepetitions(0, 0);
    }

    static void GenerateCombinationsNoRepetitions(int index, int start)
    {
        if (index >= k)
        {
            PrintCombinations();
        }
        else
        {
            for (int i = start; i < n; i++)
            {
                arr[index] = i;
                GenerateCombinationsNoRepetitions(index + 1, i + 1);
            }
        }
    }

    static void PrintCombinations()
    {
        Console.Write("(");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(numbers[arr[i]]);
            if (i!=arr.Length-1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(")");
    }
}

