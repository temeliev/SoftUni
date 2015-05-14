using System;
using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals. 
class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();

        foreach (var i in input)
        {
            Console.Write("\\u" + ((int)i).ToString("X4").ToLower());
        }

        Console.WriteLine();
    }
}

