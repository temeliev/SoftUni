using System;

class PaintBall
{
    static void Main()
    {
        string command = "";
        int[] canvas = new int[10];
        int shootCounter = 1;

        for (int i = 0; i < canvas.Length; i++)
        {
            canvas[i] = 1023;
        }

        while (command != "End")
        {
            string[] input = Console.ReadLine().Split();
            if (input[0] == "End")
            {
                command = "End";
            }
            else
            {
                int[] numbers = Array.ConvertAll(input, int.Parse);
                int row = numbers[0];
                int column = numbers[1];
                int radius = numbers[2];
                int startRow = Math.Max(0, row - radius);
                int endRow = Math.Min(row + radius, 9);
                int startCol = Math.Max(0, column - radius);
                int endCol = Math.Min(column + radius, 9);

                for (int i = startRow; i <= endRow; i++)
                {
                    for (int bit = startCol; bit <= endCol; bit++)
                    {
                        int bitValue = (canvas[i] >> bit) & 1;
                        if (shootCounter % 2 == 0 && bitValue == 0)
                        {
                            canvas[i] |= (1 << bit);
                        }
                        else if (shootCounter % 2 != 0 && bitValue == 1)
                        {
                            canvas[i] ^= (1 << bit);
                        }

                    }
                }
                shootCounter++;
            }

        }

        int sum = 0;

        for (int i = 0; i < canvas.Length; i++)
        {
            sum += canvas[i];
        }

        Console.WriteLine(sum);
    }
}

