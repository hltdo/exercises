using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BinarySearch
{
    public class BinarySearch
    {
        public static void Main()
        {
            int[] array = { 1, 2, 5, 7, 9, 10, 12, 14, 16, 17, 19};
            
            Console.WriteLine(FindElement(array, 19));

        }

        public static int FindElement(int[] array, int elementToFind)
        {
            int min = 0;
            int max = array.Length;
            int guess = (max + min) / 2;

            while (max>=min)
            {
                if (array[guess] == elementToFind)
                {
                    return guess;
                }
                else if (array[guess] > elementToFind)
                {
                    max = guess - 1;
                }
                else if (array[guess] < elementToFind)
                {
                    min = guess + 1;
                }

                guess = (max + min) / 2;
            }
            return -1;
        }
    }
}
