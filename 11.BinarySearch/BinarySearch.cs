using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 11. Binary search
Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */
class BinarySearch
{
    static void Main(string[] args)
    {
        Console.WriteLine("Length of array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        //Enter elements in array
        Console.WriteLine("Enter elements of the array: ");
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        //Sort array
        Array.Sort(array);

        Console.WriteLine("Enter the value of the element to find its corresponding index: ");
        int value = int.Parse(Console.ReadLine());

        //Initializing helping variables
        bool valueExist = true;
        int startIndex = 0;
        int endIndex = length - 1;
        int currentIndex = length / 2;

        //Applying Binary search algorithm
        while (array[currentIndex] != value)
        {
            if (array[currentIndex] > value)
            {
                endIndex = currentIndex;
                currentIndex = (endIndex - startIndex) / 2;
            }
            else
            {
                startIndex = currentIndex;
                currentIndex = ((startIndex/2)+1) + (endIndex / 2);/*In order to avoid int overflow - first, we divide
                                                                    * the two boundaries of the current range, then add them up.*/
            }
            if (((endIndex - startIndex) == 0) && (array[currentIndex]!=value))
            {
                valueExist = false;
                break;
            }
        }
        //Check if the value exist in the array
        if (valueExist)
        {
            Console.WriteLine("The element {0} is at position {1}", value, currentIndex);
        }
        else
        {
            Console.WriteLine("There is no element {0} in the array!", value);
        }
       


    }
}

