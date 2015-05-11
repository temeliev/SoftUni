using System;
//Write a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. 
//On the first line, you will receive the rows N and columns M. On the next N lines you will receive each row with its columns.
//Print the elements of the 3 x 3 square as a matrix, along with their sum.
class MaximalSum
{
    private const int inside_matrix_size = 3;
    static void Main()
    {
        string[] input = "4 5".Split();
        int rows = int.Parse(input[0]);
        int columns = int.Parse(input[1]);
        int[,] matrix = new int[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            string[] numbers = Console.ReadLine().Split();
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = int.Parse(numbers[col]);
            }
        }

        int insideRows = rows - inside_matrix_size;
        int insideColumns = (columns - inside_matrix_size) / 2;
        if (insideRows >= 0 && insideColumns >= 0)
        {
            int[,] inMatrix = new int[inside_matrix_size, inside_matrix_size];
            int inRow = 0;
            int inCol = 0;
            int sum = 0;

            for (int row = insideRows; row < insideRows + inside_matrix_size; row++)
            {
                for (int col = insideColumns; col < insideColumns + inside_matrix_size; col++)
                {
                    sum += matrix[row, col];
                    inMatrix[inRow, inCol] = matrix[row, col];
                    inCol++;
                }
                inRow++;
                inCol = 0;
            }

            Console.WriteLine("Sum = {0}", sum);

            PrintMatrix(inMatrix);
        }

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
}

