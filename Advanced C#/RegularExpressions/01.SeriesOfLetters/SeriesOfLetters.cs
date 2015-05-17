using System;
using System.Text.RegularExpressions;

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
class SeriesOfLetters
{
    static void Main()
    {
        Regex pattern = new Regex("(.)\\1+");
         
        Console.WriteLine(pattern.Replace(Console.ReadLine(), "$1"));
    }
}

