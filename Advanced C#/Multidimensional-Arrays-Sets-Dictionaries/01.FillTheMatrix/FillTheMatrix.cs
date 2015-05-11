using System;
//Write two programs that fill and print a matrix of size N x N. 
//Filling a matrix in the regular pattern (top to bottom and left to right) is boring. 
//Fill the matrix as described in both patterns below:
class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter size: ");
        int n = int.Parse(Console.ReadLine());
        FillPatternA(n);
        Console.WriteLine();
        FillPatternB(n);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    private static void FillPatternA(int dimension)
    {
        int[,] matrix = new int[dimension, dimension];
        int count = 1;
        for (int col = 0; col < dimension; col++)
        {
            for (int row = 0; row < dimension; row++)
            {
                matrix[row, col] = count++;
            }
        }

        PrintMatrix(matrix);
    }

    private static void FillPatternB(int dimension)
    {
        int[,] matrix = new int[dimension, dimension];
        int count = 1;
        bool isIncreasing = true;
        int row = 0;
        for (int col = 0; col < dimension; col++)
        {
            while ((isIncreasing && row < dimension) || (!isIncreasing && row >= 0))
            {
                matrix[row, col] = count++;

                if (isIncreasing)
                {
                    row++;
                }
                else
                {
                    row--;
                }
            }

            isIncreasing = !isIncreasing;
            if (isIncreasing)
            {
                row++;
            }
            else
            {
                row--;
            }
        }
        PrintMatrix(matrix);
    }


}


