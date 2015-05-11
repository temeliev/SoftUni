using System;
using System.Runtime.InteropServices;

//Write a program which reads a string matrix from the console and performs certain operations with its elements. 
//User input is provided like in the problem above – first you read the dimensions and then the data. 
//Remember, you are not required to do this step first, you may add this functionality later.  
//Your program should then receive commands in format: "swap x1 y1 x2 y2" where x1, x2, y1, y2 are coordinates in the matrix.
//In order for a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less). 
//You should swap the values at the given coordinates (cell [x1, y1] with cell [x2, y2]) and print the matrix at each step (thus you'll be able to check if the operation was performed correctly). 
//If the command is not valid (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist), print "Invalid input!" and move on to the next command.
//Your program should finish when the string "END" is entered. 
class MatrixShuffling
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        string command = "";
        string[] input;
        while (command != "END")
        {
            input = Console.ReadLine().Split();
            if (input[0] == "swap" && input.Length == 5)
            {
                int row1 = int.Parse(input[1]);
                int col1 = int.Parse(input[2]);
                int row2 = int.Parse(input[3]);
                int col2 = int.Parse(input[4]);
                if (row1 > rows || col1 > columns || row2 > rows || col2 > columns)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    Console.WriteLine("(after swapping {0} and {1}):", matrix[row1, col1], matrix[row2, col2]);
                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;

                    PrintMatrix(matrix);
                }

            }
            else if (input[0] == "END")
            {
                command = "END";
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }

    private static void PrintMatrix(string[,] matrix)
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

