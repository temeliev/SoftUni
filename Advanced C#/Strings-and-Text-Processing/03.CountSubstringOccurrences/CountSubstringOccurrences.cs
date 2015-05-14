using System;
 
//Write a program to find how many times a given string appears in a given text as substring. 
//The text is given at the first input line. 
//The search string is given at the second input line. 
//The output is an integer number. 
//Please ignore the character casing. 
//Overlapping between occurrences is allowed
class CountSubstringOccurrences
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string word = Console.ReadLine().ToLower();
        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            string temp = text.Substring(i);

            if (temp.StartsWith(word))
            {
                count++;
            }

        }

        Console.WriteLine(count);
    }
}

