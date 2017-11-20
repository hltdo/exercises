using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 7. Selection sort
Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */
class SelectionSort
{
    static void Main(string[] args)
    {
        //You can use the samples below to test the program

        int[] array = { 5, 7, 9, 1, 4, 6, 3, 15, 12, 1, 2 };
        //int[] array = { -20, 13, 15, -18, 5, 43, 12, 182, 0, -4, 9 };
        //int[] array = { 60, 39, 12, 7, 19, 4, 3, 56};
        //int[] array = { 0, 5, -2, 4, 1, 0, -6, 3 };


        //To enter your own values for testing uncomment the lines below:

        /*Console.WriteLine("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        Console.WriteLine("Enter elements of the array: ");
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        */
   
        //SELECTION SORT ALGORITHM:
        for (int i = 0; i < array.Length; i++)
        {
            int current = array[i];//initializing variable to compare the current element with the others from the array
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] < current)
                {
                    int temp = array[j];
                    array[j] = current;
                    current = temp;
                }
            }
            array[i] = current;
        }

        //BUBBLE SORT ALGORITHM
        /*
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
         */

        //Print sorted algorithm
        Console.WriteLine(String.Join(", ", array));
    }
}

