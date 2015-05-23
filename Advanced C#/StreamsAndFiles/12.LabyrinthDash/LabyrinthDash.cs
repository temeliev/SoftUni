using System;

class LabyrinthDash
{
    private static int _lives = 3;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[][] board = new char[n][];

        for (int i = 0; i < n; i++)
        {
            board[i] = Console.ReadLine().ToCharArray();
        }

        char[] commands = Console.ReadLine().ToCharArray();
        int row = 0;
        int col = 0;
        int movesCounter = 0;
        string lastDirection = String.Empty;


        for (int i = 0; i < commands.Length; i++)
        {

            char direction = commands[i];

            if (direction == 'v')
            {
                row++;
                lastDirection = "Down";
            }
            else if (direction == '>')
            {
                col++;
                lastDirection = "Right";
            }
            else if (direction == '<')
            {
                col--;
                lastDirection = "Left";
            }
            else
            {
                row--;
                lastDirection = "Up";
            }

            if (row < 0 || col < 0 || row >= n || col >= board[row].Length)
            {
                Console.WriteLine("Fell off a cliff! Game Over!");
                movesCounter++;
                break;
            }

            char pos = board[row][col];

            if (pos == ' ')
            {
                Console.WriteLine("Fell off a cliff! Game Over!");
                movesCounter++;
                break;
            }

            if (pos == '_' || pos == '|')
            {
                Console.WriteLine("Bumped a wall.");
                if (lastDirection == "Up")
                {
                    row++;
                }
                else if (lastDirection == "Right")
                {
                    col--;
                }
                else if (lastDirection == "Left")
                {
                    col++;
                }
                else
                {
                    row--;
                }
                movesCounter--;
            }
            else if (pos == '@' || pos == '#' || pos == '*')
            {
                Console.WriteLine("Ouch! That hurt! Lives left: {0}", --_lives);
            }
            else if (pos == '$')
            {
                Console.WriteLine("Awesome! Lives left: {0}", ++_lives);
                board[row][col] = '.';
            }
            else if (pos == '.')
            {
                Console.WriteLine("Made a move!");
            }
            movesCounter++;
            if (_lives == 0)
            {
                Console.WriteLine("No lives left! Game Over!");
                break;
            }
        }

        Console.WriteLine("Total moves made: {0}", movesCounter);
    }
}

