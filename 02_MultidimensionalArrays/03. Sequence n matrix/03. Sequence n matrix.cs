using System;

/*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
  of several neighbour elements located on the same line, column or diagonal.
  Write a program that finds the longest sequence of equal strings in the matrix.
 */

class SequenceNMatrix
{
    static void Main()
    {
        //Console.WriteLine("Enter the rows N of the matrix: ");
        //int n = 3; //int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the cols M of the matrix: ");
        //int m = 4; //int.Parse(Console.ReadLine());

        ////Fill matrix
        /*for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }*/

        //Test
        string[,] matrix = new string[4, 4]
        {
            {"pas", "muu", "soa","s"},
            {"pas", "miau", "bau", "chao"},
            {"tos", "tos", "tos", "tos"},
            {"dra", "san", "mack", "ten"},   
        };

        //Another Test

        //string[,] matrix = new string[3,4]
        //{
        //    {"ha", "hi", "ho","he"},
        //    {"ho", "ha", "hi", "he"},
        //    {"xxx", "ho", "ha", "hu"}           
        //};

        string bestString = string.Empty;
        int bestOccurence = 0;

        //Check row, col and diagonals sequences
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int counter = 0;
                for (int platformRow = row; platformRow < matrix.GetLength(0); platformRow++)
                {
                    for (int platformCol = col; platformCol < matrix.GetLength(1); platformCol++)
                    {
                        if (matrix[row, col].Equals(matrix[platformRow, platformCol]))
                        {
                            counter++;
                        }

                        if (counter > bestOccurence)
                        {
                            bestOccurence = counter;
                            bestString = matrix[row, col];
                        }
                    }
                }
            }
        }
        //Print Longest Sequence
        Console.Write("Longest sequence: {");
        for (int i = 0; i < bestOccurence; i++)
        {
            if (i==bestOccurence-1)
            {
                Console.Write("{0}}}",bestString);
            }
            else
            {
                Console.Write("{0}, ",bestString);
            }
        }
        Console.WriteLine();
    }
}

