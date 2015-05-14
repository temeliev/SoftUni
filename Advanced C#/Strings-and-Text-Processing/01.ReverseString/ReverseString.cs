using System;
using System.Text;

//Write a program that reads a string from the console, reverses it and prints the result back at the console.
class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder build = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            build.Append(input[i]);
        }

        Console.WriteLine(build.ToString());
    }
}

