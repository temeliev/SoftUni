using System;
using System.Text.RegularExpressions;

//Write a program that reads a keyword and some text from the console and prints all sentences from the text, containing that word. 
//A sentence is any sequence of words ending with '.', '!' or '?'
class SentenceExtractor
{
    static void Main()
    {
        string keyword = Console.ReadLine();
        string text = Console.ReadLine();
        Regex reg = new Regex(@"\s*[A-Za-z,;'\""\s’–-]+[.?!]");
        MatchCollection matches = reg.Matches(text);
        reg = new Regex(string.Format(@"\b{0}\b", keyword));

        foreach (Match m in matches)
        {
            var result = reg.Match(m.Groups[0].Value);
            if (result.Success)
            {
                Console.WriteLine(m.Groups[0].Value);
            }
        }
    }
}

