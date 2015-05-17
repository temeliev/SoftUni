using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//Write a program to extract all hyperlinks (<href=…>) from a given text. 
//The text comes from the console on a variable number of lines and ends with the command "END". 
//Print at the console the href values in the text.
//The input text is standard HTML code.
//It may hold many tags and can be formatted in many different forms (with or without whitespace). 
//The <a> elements may have many attributes, not only href. 
//You should extract only the values of the href attributes of all <a> elements.

class ExtractHyperlinks
{
    static void Main()
    {
        StringBuilder builder = new StringBuilder();
        List<string> links = new List<string>();
        string command = "";

        while (command != "END")
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                command = input;
            }
            else
            {
                builder.AppendLine(input);
            }
        }
        
        string text = builder.ToString();
        Regex pattern = new Regex(@"(<a([^>]+)>)");
        MatchCollection tags = pattern.Matches(text);

        pattern = new Regex("\\s*href\\s*=\\s*(\"([^\"]*\")|'[^']*'|([^'\">\\s]+))");

        foreach (Match t in tags)
        {
            var result = pattern.Match(t.Groups[0].Value);
            if (result.Success)
            {
                Console.WriteLine(result.Groups[1].Value.Trim(new char[] { '\'', '"' }));
            }
        }
    }
}

