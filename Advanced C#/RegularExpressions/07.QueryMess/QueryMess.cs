using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//Ivancho participates in a team project with colleagues at SoftUni.  
//They have to develop an application, but something mysterious happened – at the last moment all team members… disappeared! 
//And guess what? He is left alone to finish the project.  
//All that is left to do is to parse the input data and store it in a special way, but Ivancho has no idea how to do that! Can you help him?
class QueryMess
{
    static void Main()
    {
        Dictionary<string, List<string>> info = new Dictionary<string, List<string>>();
        List<string> links = new List<string>();
        string command = "";
        Regex repPattern = new Regex(@"\s{2,}");
        Regex pattern = new Regex(@"([^=&]+)=([^&=]+)");

        while (command != "END")
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                command = input;
            }
            else
            {
                input = input.Replace("%20", " ").Replace("+", " ").Replace("?", "&");
                input = repPattern.Replace(input, " ");
                MatchCollection matches = pattern.Matches(input);
                foreach (Match match in matches)
                {
                    string key = match.Groups[1].ToString().Trim();
                    string value = match.Groups[2].ToString().Trim();

                    if (!info.ContainsKey(key))
                    {
                        info[key] = new List<string>();
                        info[key].Add(value);
                    }
                    else
                    {
                        info[key].Add(value);
                    }
                }
                Print(info);
                info.Clear();
                Console.WriteLine();
            }
        }
 
    }

    private static void Print(Dictionary<string, List<string>> info)
    {
        foreach (var i in info)
        {
            Console.Write("{0}=[{1}]", i.Key, string.Join(", ", i.Value));
        }
    }
   
}

