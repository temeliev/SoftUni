using System;
using System.Linq;
//Write a program that reads an array of strings and finds in it all sequences of equal elements (comparison should be case-insensitive). 
//The input strings are given as a single line, separated by a space
class SequencesOfEqualStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string[] distinct = input.Distinct().ToArray();

        for (int i = 0; i < distinct.Length; i++)
        {
            for (int i1 = 0; i1 < input.Length; i1++)
            {
                if (distinct[i] == input[i1])
                {
                    Console.Write(distinct[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

