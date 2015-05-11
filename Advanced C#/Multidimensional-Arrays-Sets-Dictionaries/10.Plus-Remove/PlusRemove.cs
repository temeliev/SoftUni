using System;
using System.Collections.Generic;

//You are given a sequence of text lines, holding symbols, small and capital Latin letters. 
//Your task is to remove all "plus shapes" in the text. 
//They may consist of small and capital letters at the same time, or of any symbol. 
//All of the X shapes below are valid:
//Every "plus shape" is 3 by 3 symbols crossing each other on 3 lines. 
//Single "plus shape" can be part of multiple "plus shapes". 
//If new "plus shapes" are formed after the first removal you don't have to remove them.
class PlusRemove
{
    static void Main()
    {
        List<char[]> chars = new List<char[]>();
        string command = "";
        
        while (command != "END")
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                command = "END";
            }
            else
            {
                chars.Add(input.ToCharArray());
            }

        }
        int verticalCount = 1;
        int horizontalCount = 1;
        Dictionary<int, HashSet<int>> markedPositions = new Dictionary<int, HashSet<int>>();

        for (int row = 0; row < chars.Count; row++)
        {
            for (int col = 0; col < chars[row].Length; col++)
            {
                char curr = chars[row][col];
                if (row + 1 < chars.Count && col < chars[row + 1].Length)
                {
                    if (AreEqual(curr, chars[row + 1][col]))
                    {
                        verticalCount++;
                        if (row + 2 < chars.Count && col < chars[row + 2].Length)
                        {
                            if (AreEqual(curr, chars[row + 2][col]))
                            {
                                verticalCount++;
                            }
                        }

                        if (col - 1 >= 0)
                        {
                            if (AreEqual(curr, chars[row + 1][col - 1]))
                            {
                                horizontalCount++;
                            }
                        }

                        if (col + 1 < chars[row + 1].Length)
                        {
                            if (AreEqual(curr, chars[row + 1][col + 1]))
                            {
                                horizontalCount++;
                            }
                        }

                        if (horizontalCount == 3 && verticalCount == 3)
                        {
                            if (!markedPositions.ContainsKey(row))
                            {
                                markedPositions[row] = new HashSet<int>();
                                markedPositions[row].Add(col);
                            }
                            else
                            {
                                markedPositions[row].Add(col);
                            }

                            if (!markedPositions.ContainsKey(row + 1))
                            {
                                markedPositions[row + 1] = new HashSet<int>();
                                markedPositions[row + 1].Add(col - 1);
                                markedPositions[row + 1].Add(col);
                                markedPositions[row + 1].Add(col + 1);
                            }
                            else
                            {
                                markedPositions[row + 1].Add(col - 1);
                                markedPositions[row + 1].Add(col);
                                markedPositions[row + 1].Add(col + 1);
                            }

                            if (!markedPositions.ContainsKey(row + 2))
                            {
                                markedPositions[row + 2] = new HashSet<int>();
                                markedPositions[row + 2].Add(col);
                            }
                            else
                            {
                                markedPositions[row + 2].Add(col);
                            }
                        }
                    }

                    verticalCount = 1;
                    horizontalCount = 1;
                }
            }
        }

        Print(markedPositions, chars);
    }

    static bool AreEqual(char char1, char char2)
    {
        if (char1 >= 'a' && char1 <= 'z')
        {
            char1 = Convert.ToChar(char1 - 32);
        }

        if (char2 >= 'a' && char2 <= 'z')
        {
            char2 = Convert.ToChar(char2 - 32);
        }

        return char1 == char2;
    }

    static void Print(Dictionary<int, HashSet<int>> dic, List<char[]> chars)
    {
        for (int i = 0; i < chars.Count; i++)
        {
            for (int i1 = 0; i1 < chars[i].Length; i1++)
            {
                if (!dic.ContainsKey(i) || !dic[i].Contains(i1))
                {
                    Console.Write(chars[i][i1]);
                }
            }
            Console.WriteLine();
        }
    }
}

