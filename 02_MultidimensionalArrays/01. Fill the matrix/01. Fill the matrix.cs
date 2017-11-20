using System;

// Write a program that fills and prints a matrix of size (n, n) 

class FillTheMatrix
{
    static void Main()
    {
        //Console.WriteLine("Enter an integer 'n' for the size of the matrix(n, n): ");
        int size = 8; //int.Parse(Console.ReadLine());
        int rows = size;
        int cols = size;

        //MATRIX A)

        int initialNumberA = 1;
        int[,] matrixA = new int[rows, cols];
        for (rows = 0; rows < matrixA.GetLength(0); rows++)
        {
            for (cols = 0; cols < matrixA.GetLength(1); cols++)
            {
                matrixA[cols, rows] = initialNumberA;
                initialNumberA++;
            }
        }
        //Print matrix A
        Console.WriteLine("Matrix A)");
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                Console.Write("{0, 3} ", matrixA[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //MATRIX B)
        int initialNumberB = 1;
        int[,] matrixB = new int[rows, cols];
        for (cols = 0; cols < matrixB.GetLength(1); cols++)
        {
            if (cols % 2 == 0)
            {
                for (rows = 0; rows < matrixB.GetLength(0); rows++)
                {
                    matrixB[rows, cols] = initialNumberB;
                    initialNumberB++;
                }
            }
            else
            {
                for (rows = matrixB.GetLength(0) - 1; rows >= 0; rows--)
                {
                    matrixB[rows, cols] = initialNumberB;
                    initialNumberB++;
                }
            }
        }

        //Print matrix B)
        Console.WriteLine("Matrix B) ");
        for (int i = 0; i < matrixB.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                Console.Write("{0, 3} ", matrixB[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //MATRIX C)
        int[,] matrixC = new int[size, size];
        int initialNumberC = 1;

        //Fill left down triangle
        for (int row = matrixC.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < (size - row); col++)
            {
                matrixC[row + col, col] = initialNumberC;
                initialNumberC++;
            }
        }

        //Fill rigth top triangle
        for (int r = 0; r < matrixC.GetLength(0) - 1; r++)
        {
            for (int c = r + 1; c < matrixC.GetLength(1); c++)
            {
                matrixC[c - r - 1, c] = initialNumberC;
                initialNumberC++;
            }
        }

        //Print Matrix C)
        Console.WriteLine("Matrix C) ");
        for (int i = 0; i < matrixC.GetLength(0); i++)
        {
            for (int j = 0; j < matrixC.GetLength(1); j++)
            {
                Console.Write("{0, 3} ", matrixC[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //MATRIX D)
        
        int[,] matrixD = new int[size, size];
        int initialNumberD = 1;
        int currentRow = 0;
        int currentCol = 0;
        string diraction = "down";

        for (int row = 0; row < matrixD.GetLength(0); row++)
        {
            for (int col = 0; col < matrixD.GetLength(1); col++)
            {
                if (diraction == "down")
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (matrixD[currentRow, currentCol] == 0)
                        {
                            matrixD[currentRow++, currentCol] = initialNumberD++;
                        }
                    }

                    diraction = "rigth";
                    currentRow--;
                }
                if (diraction == "rigth")
                {
                    currentCol++;
                    for (int i = 0; i < size - 1; i++)
                    {
                        if (matrixD[currentRow, currentCol] == 0)
                        {
                            matrixD[currentRow, currentCol++] = initialNumberD++;
                        }
                    }

                    diraction = "up";
                    currentCol--;
                }
                if (diraction == "up")
                {
                    currentRow--;
                    for (int i = 0; i < size - 1; i++)
                    {
                        if (matrixD[currentRow, currentCol] == 0)
                        {
                            matrixD[currentRow--, currentCol] = initialNumberD++;
                        }
                    }

                    diraction = "left";
                    currentRow++;
                }
                if (diraction == "left")
                {
                    currentCol--;
                    for (int i = 0; i < size - 1; i++)
                    {
                        if (matrixD[currentRow, currentCol] == 0)
                        {
                            matrixD[currentRow, currentCol--] = initialNumberD++;
                        }
                    }

                    diraction = "down";
                    currentCol++;
                    currentRow++;
                }
            }
        }

        //Print Matrix D)
        Console.WriteLine("Matrix D) ");
        for (int i = 0; i < size; i++) // print
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("{0, 3} ", matrixD[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

