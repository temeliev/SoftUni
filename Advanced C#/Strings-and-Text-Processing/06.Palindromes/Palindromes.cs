using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console on a single line, separated by comma and space. 
//Use spaces, commas, dots, question marks and exclamation marks as word delimiters.
//Print only unique palindromes, sorted lexicographically.
class Palindromes
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' });
        SortedSet<string> palindromes = new SortedSet<string>();

        for (int i = 0; i < input.Length; i++)
        {
            string word = input[i];
            int leftCount = 0;
            int rightCount = 0;
            for (int start = 0, end = word.Length - 1; start < word.Length; start++, end--)
            {
                leftCount += word[start];
                rightCount += word[end];

                if ((start == end || start + 1 == end) && leftCount == rightCount)
                {
                    palindromes.Add(word);
                }
            }
        }

        if (palindromes.Count > 0)
        {
            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}

