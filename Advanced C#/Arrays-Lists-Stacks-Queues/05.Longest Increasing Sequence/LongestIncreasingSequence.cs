using System;
using System.Collections.Generic;
//Write a program to find all increasing sequences inside an array of integers. 
//The integers are given on a single line, separated by a space. 
//Print the sequences in the order of their appearance in the input array, each at a single line. 
//Separate the sequence elements by a space. Find also the longest increasing sequence and print it at the last line. 
//If several sequences have the same longest length, print the left-most of them
class LongestIncreasingSequence
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(input, int.Parse);
        List<int> currentList = new List<int>();
        List<int> longestList = new List<int>();

        int prev = numbers[0];
        int current;
        int index = 1;

        while (index < numbers.Length)
        {
            current = numbers[index];

            if (prev < current)
            {
                currentList.Add(prev);
            }
            else
            {
                currentList.Add(prev);

                Console.WriteLine(string.Join(" ", currentList));
                if (currentList.Count > longestList.Count)
                {
                    longestList.Clear();
                    longestList.AddRange(currentList);
                }
                currentList.Clear();

            }

            if (index == numbers.Length - 1)
            {
                if (currentList.Count == 0)
                {
                    Console.WriteLine(current);
                }
                else
                {
                    currentList.Add(current);
                    Console.WriteLine(string.Join(" ", currentList));
                    if (currentList.Count > longestList.Count)
                    {
                        longestList.Clear();
                        longestList.AddRange(currentList);
                    }
                }
            }

            prev = current;
            index++;
        }

        Console.WriteLine("Longest: {0}", string.Join(" ", longestList));

    }
}

