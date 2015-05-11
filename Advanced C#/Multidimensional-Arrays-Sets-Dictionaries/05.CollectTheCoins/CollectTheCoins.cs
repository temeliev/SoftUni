using System;
using System.Linq;

//Working with multidimensional arrays can be (and should be) fun. Let's make a game out of it.
//You receive the layout of a board from the console.
//Assume it will always have 4 rows which you'll get as strings, each on a separate line. 
//Each character in the strings will represent a cell on the board. Note that the strings may be of different length.
//You are the player and start at the top-left corner (that would be position [0, 0] on the board). 
//On the fifth line of input you'll receive a string with movement commands which tell you where to go next, 
//it will contain only these four characters – '>' (move right), '<' (move left), '^' (move up) and 'v' (move down).  
//You need to keep track of two types of events – collecting coins (represented by the symbol '$' of course) 
//and hitting the walls of the board (when the player tries to move off the board to invalid coordinates). 
//When all moves are over, print the amount of money collected and the number of walls hit.

class CollectTheCoins
{
    private const int max_size = 4;
    static void Main()
    {
        char[][] board = new char[max_size][];

        for (int i = 0; i < 4; i++)
        {
            board[i] = Console.ReadLine().ToCharArray();
        }

        char[] commands = Console.ReadLine().ToCharArray();
        int row = 0;
        int col = 0;
        int wallCounter = 0;
        int coinCounter = 0;

        for (int i = 0; i < commands.Length; i++)
        {
            char pos = board[row][col];
            if (pos == '$')
            {
                coinCounter++;
            }

            char direction = commands[i];

            if (direction == 'V')
            {
                row++;

            }
            else if (direction == '>')
            {
                col++;
            }
            else if (direction == '<')
            {
                col--;
            }
            else
            {
                row--;
            }

            if (row < 0)
            {
                wallCounter++;
                row++;
            }
            else if (col < 0)
            {
                wallCounter++;
                col++;
            }
            else if (row >= max_size)
            {
                wallCounter++;
                row--;
            }
            else if (col >= board[row].Length)
            {
                wallCounter++;
                row--;
            }
        }

        Console.WriteLine("Coins collected: {0}", coinCounter);
        Console.WriteLine("Wall hit: {0}", wallCounter);
    }
}

