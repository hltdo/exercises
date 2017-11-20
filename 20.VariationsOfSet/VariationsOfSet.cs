using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 20.* Variations of set
Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
Example:

N	K	result
3	2	{1, 1} 
        {1, 2} 
        {1, 3} 
        {2, 1} 
        {2, 2} 
        {2, 3} 
        {3, 1} 
        {3, 2} 
        {3, 3}
 */

class VariationsOfSet
{

    const int n = 3; //int.Parse(Console.ReadLine());
    const int k = 2; //int.Parse(Console.ReadLine());
    static int[] array = new int[n];
	
    static int[] arr = new int[k];

    static void Main()
    {
        for (int i = 0; i < n; i++)
		{
			array[i] = i+1; 
		}
        GenerateVariationsWithRepetitions(0);
    }

    static void GenerateVariationsWithRepetitions(int index)
    {
        if (index >= k)
        {
            PrintVariations();
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                arr[index] = i;
                GenerateVariationsWithRepetitions(index + 1);
            }
        }
    }

    static void PrintVariations()
    {
        Console.Write("(");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(array[arr[i]]);
            if (i!=arr.Length -1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(")");
    }
}

