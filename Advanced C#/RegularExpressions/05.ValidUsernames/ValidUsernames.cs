using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ValidUsernames
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> validUsernames = new List<string>();
        List<string> bestUserNames = new List<string>();
        int maxSum = int.MinValue; 
        Regex pattern = new Regex(@"\b[a-zA-Z]\w{2,25}\b");
        MatchCollection matches = pattern.Matches(input);

        foreach (Match m in matches)
        {
            string userName = m.Groups[0].Value;
            userName = userName.Trim();
            validUsernames.Add(userName);
        }

        for (int i = 1; i < validUsernames.Count; i++)
        {
            int sum = validUsernames[i].Length + validUsernames[i - 1].Length;
            if (sum > maxSum)
            {
                maxSum = sum;
                bestUserNames.Clear();
                bestUserNames.Add(validUsernames[i - 1]);
                bestUserNames.Add(validUsernames[i]);
            }
        }

        bestUserNames.ForEach(x => Console.WriteLine(x));
    }
}

