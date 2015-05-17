using System;
using System.Text.RegularExpressions;

//Write a program to extract all email addresses from a given text. 
//The text comes at the only input line. Print the emails on the console, each at a separate line. 
//Emails are considered to be in format <user>@<host>, where: 
//	<user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them. Examples of valid users: "stephan", "mike03", "s.johnson", "st_steward", "softuni-bulgaria", "12345". 
//Examples of invalid users: ''--123", ".....", "nakov_-", "_steve", ".info". 
//	<host> is a sequence of at least two words, separated by dots '.'. 
//Each word is sequence of letters and can have hyphens '-' between the letters. Examples of hosts: "softuni.bg", "software-university.com", "intoprogramming.info", "mail.softuni.org". 
//Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-". 
//	Examples of valid emails: info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy. 
//	Examples of invalid emails: --123@gmail.com, …@mail.bg, .info@info.info, _steve@yahoo.cn, mike@helloworld, mike@.unknown.soft., s.johnson@invalid-.

class ExtractEmails
{
    static void Main()//([-+.]*)\w*@\w+([-.\w+])*\.(\w+)   \b[a-zA-Z][\w-.]*@\w[-.\w]*\.\w+
    {
        string input = Console.ReadLine();
        Regex pattern = new Regex(@"[\w-.]*@\w[-.\w]*\.\w+");

        MatchCollection matches = pattern.Matches(input);
        pattern = new Regex("^[a-zA-Z]");
        foreach (Match m in matches)
        {
            var result = pattern.Match(m.Groups[0].Value);
            if (result.Success)
            {
                Console.WriteLine(m.Groups[0].Value);
            }
        }
    }
}

