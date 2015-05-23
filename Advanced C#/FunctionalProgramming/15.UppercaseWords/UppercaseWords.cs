using System;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

namespace _15.UppercaseWords
{
    class UppercaseWords
    {
        static void Main()
        {
            string input = string.Empty;
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                sb.AppendLine(SecurityElement.Escape(input));
            }

            string pattern = @"(?<![a-zA-Z])[A-Z]+(?![A-Za-z])";
            Regex regex = new Regex(pattern);
            string result = sb.ToString();
            MatchCollection matches = regex.Matches(result);

            foreach (Match match in matches)
            {
                string word = match.Groups[0].Value;
                pattern = string.Concat(@"(?<![a-zA-Z])", word, @"(?![A-Za-z])");
                regex = new Regex(pattern);
                result = regex.Replace(result, ConvertWord(word));
            }

            Console.WriteLine(result);
        }

        private static string ConvertWord(string word)
        {
            string reversed = new string(word.Reverse().ToArray());
            if (word == reversed)
            {
                reversed = String.Empty;
                foreach (var letter in word)
                {
                    reversed += new String(letter, 2);
                }
            }

            return reversed;
        }
    }
}
