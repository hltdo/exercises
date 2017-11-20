using System;

/*Problem 2. Maximal sum
 * Write a program that reads a rectangular matrix of size N x M and finds in it the square
 * 3 x 3 that has maximal sum of its elements.*/
class MaximalSum
{
    static void Main()
    {
        //Console.WriteLine("Enter the rows (N) of the matrix: ");
        //int.Parse(Console.ReadLine));
        //Console.WriteLine("Enter the cols (M) of the matrix: ");
        //int.Parse(Console.ReadLine));
        //int [,] matrix = new int [n,m];

        int[,] matrix =
        {
            {991, -0, -3, -4, -5, -1, -90000},
            {-598, -65, -7, -8, -10, -2, -10},
            {-9, -10, -11, -12, -19, -8, -6},
            {-7000, -12 ,-1, -199, -10, -3, -10}
        };

        int bestSum = int.MinValue;
        int startIndexRow = 0;
        int startIndexCol = 0;
        int currentSum = int.MinValue;
        int r;
        int c;

        for (r = 0; r < matrix.GetLength(0) - 2; r++)
        {
            for (c = 0; c < matrix.GetLength(1) - 2; c++)
            {
                currentSum = matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] + matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2] + matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];

                if (bestSum < currentSum)
                {
                    bestSum = currentSum;
                    startIndexRow = r;
                    startIndexCol = c;
                }
            }   
        }

        //Print 3 x 3 square that has maximal sum

        for (int i = startIndexRow; i < startIndexRow + 3; i++)
        {
            for (int j = startIndexCol; j < startIndexCol + 3; j++)
            {
                Console.Write("{0, 3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

