using System;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a> with corresponding tags [URL href=…]…[/URL]. 
//Print the result on the console.
class ReplaceTag
{
    static void Main()
    {
        StringBuilder bd = new StringBuilder();

        string input = string.Empty;
        //за да спре цикъла въведете празен ред!!!
        while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
        {
            bd.Append(input);
        }

        Regex pattern = new Regex(@"<a\shref=(?<url>.*?)>(?<text>.*?)</a>");
        MatchCollection matches = pattern.Matches(bd.ToString());

        foreach (Match m in matches)
        {
            Console.WriteLine("[URL href=" + m.Groups["url"].Value + "]" + m.Groups["text"].Value + "[/URL]");
        }

    }
}
