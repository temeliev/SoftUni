using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

//You are given a sequence of text lines. 
//Assume these text lines form a matrix of characters (pad the missing positions with spaces to build a rectangular matrix). 
//Write a program to rotate the matrix by 90, 180, 270, 360, … degrees. 
//Print the result at the console as sequence of strings.
class StringMatrixRotation
{
    private static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ', '(', ')' });
        int degrees = int.Parse(input[1]) % 360;
        List<string> words = new List<string>();

        string command = "";
        while (command != "END")
        {
            string word = Console.ReadLine();
            if (word == "END")
            {
                command = "END";
            }
            else
            {
                words.Add(word);
            }
        }
        int height = words.Count;
        int width = words.OrderBy(x => x.Length).Last().Length;

        string[] chars = new string[height];
        for (int i = 0; i < words.Count; i++)
        {
            chars[i] = words[i].PadRight(width, ' ');
        }

        if (degrees == 90)
        {
            for (int col = 0; col < width; col++)
            {
                for (int row = height - 1; row >= 0; row--)
                {
                    Console.Write(chars[row][col]);
                }
                Console.WriteLine();

            }
        }
        else if (degrees == 180)
        {
            for (int row = height - 1; row >= 0; row--)
            {
                for (int col = width - 1; col >= 0; col--)
                {
                    Console.Write(chars[row][col]);
                }
                Console.WriteLine();
            }
        }
        else if (degrees == 270)
        {
            for (int row = width - 1; row >= 0; row--)
            {
                for (int col = 0; col < height; col++)
                {
                    Console.Write(chars[col][row]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(chars[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}

