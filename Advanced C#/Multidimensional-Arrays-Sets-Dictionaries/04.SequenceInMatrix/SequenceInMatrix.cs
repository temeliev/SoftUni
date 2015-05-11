using System;
using System.Linq;

//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix.
class SequenceInMatrix
{
    private static int _maxCount;
    private static string _currentString;
    static void Main()
    {
        _maxCount = int.MinValue;
        _currentString = "";
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Console.Write("({0},{1}) = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
 
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                SetMaxValues(GetHorizontalCount(matrix, matrix[i, j], i, j), matrix[i, j]);
                SetMaxValues(GetVerticalCount(matrix, matrix[i, j], i, j), matrix[i, j]);
                SetMaxValues(GetRightDiagonalCount(matrix, matrix[i, j], i, j), matrix[i, j]);
                SetMaxValues(GetLeftDiagonalCount(matrix, matrix[i, j], i, j), matrix[i, j]);
            }
        }

        PrintResult();
    }

    static void SetMaxValues(int currentCount, string currString)
    {
        if (_maxCount < currentCount)
        {
            _maxCount = currentCount;
            _currentString = currString;
        }
    }

    static void PrintResult()
    {
        for (int i = 0; i < _maxCount; i++)
        {
            if (i < _maxCount - 1)
            {
                Console.Write(_currentString + ", ");
            }
            else
            {
                Console.WriteLine(_currentString);
            }
        }
    }

    private static int GetHorizontalCount(string[,] matrix, string current, int row, int col)
    {
        int counter = 0;
        for (int i = col; i < matrix.GetLength(1); i++)
        {
            if (matrix[row, i] == current)
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        return counter;
    }

    private static int GetVerticalCount(string[,] matrix, string current, int row, int col)
    {
        int counter = 0;
        for (int i = row; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, col] == current)
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        return counter;
    }

    private static int GetRightDiagonalCount(string[,] matrix, string current, int row, int col)
    {
        int counter = 0;
        int startRow = row;
        int startCol = col;
        bool isSearching = true;

        while (isSearching)
        {
            if (matrix[startRow++, startCol++] == current)
            {
                counter++;
                if (startCol >= matrix.GetLength(1) || startRow >= matrix.GetLength(0))
                {
                    isSearching = false;

                }
            }
            else
            {
                isSearching = false;
            }
        }

        return counter;
    }

    private static int GetLeftDiagonalCount(string[,] matrix, string current, int row, int col)
    {
        int counter = 0;
        int startRow = row;
        int startCol = col;
        bool isSearching = true;

        while (isSearching)
        {
            if (matrix[startRow++, startCol--] == current)
            {
                counter++;
                if (startCol < 0 || startRow >= matrix.GetLength(0))
                {
                    isSearching = false;
                }
            }
            else
            {
                isSearching = false;
            }

        }

        return counter;
    }
}

