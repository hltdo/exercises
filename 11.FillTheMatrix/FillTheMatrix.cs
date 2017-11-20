using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FillTheMatrix
{
    public class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int n = 4;
            FillStandart(n);
            Console.WriteLine();
            FillA(n);
            Console.WriteLine();
            FillB(n);
            Console.WriteLine();
            FillC(n);
        }

        public static void FillStandart(int n)
        {
            // Eg.
            // n = 4
            // 1 2 3 4
            // 5 6 7 8
            // 9 10 11 12
            // 13 14 15 16
            int[,] array = new int[n, n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    counter++;
                    array[i, j] = counter;
                }
            }

            PrintMatrix(array);
        }


        public static void FillA(int n)
        {
            // Eg.
            // n = 4
            // 1 5 9 13
            // 2 6 10 14
            // 3 7 11 15
            // 4 8 12 16
            int[,] array = new int[n, n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    counter++;
                    array[j, i] = counter;
                }
            }

            PrintMatrix(array);
        }

        public static void FillB(int n)
        {
            // Eg.
            // n = 4
            // 1 8 9 16
            // 2 7 10 15
            // 3 6 11 14
            // 4 5 12 13
            int[,] array = new int[n, n];
            int counter = 0;
            int row, col = n;
            for (col = 0; col < n; col++)
            {

                if (col % 2 == 0)
                {
                    for (row = 0; row < n; row++)
                    {
                        counter++;
                        array[row, col] = counter;
                    }
                }
                else
                {
                    for (row = n-1; row >= 0; row--)
                    {
                        counter++;
                        array[row, col] = counter;
                    }
                }
            }

            PrintMatrix(array);
        }


        public static void FillC(int n)
        {
            // Eg.
            // n = 4
            // 7 11 14 16
            // 4 8 12 15
            // 2 5 9 13
            // 1 3 6 10
            int[,] array = new int[n, n];
            int counter = 1;
            int row, col = n;

            for (row = n-1 ; row >= 0; row--)
            {
                for (col = 0; col < (n - row); col++)
                {
                    array[row + col, col] = counter;
                    counter++;
                }
            }

            //Fill rigth top triangle
            for (int r = 0; r < n - 1; r++)
            {
                for (int c = r + 1; c < n; c++)
                {
                    array[c - r - 1, c] = counter;
                    counter++;
                }
            }

            PrintMatrix(array);
        }



        public static void PrintMatrix(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", array[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
