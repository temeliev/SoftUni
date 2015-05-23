using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _16.LittleJohn
{
    class LittleJohn
    {
        static void Main()
        {
            string input = string.Empty;
            Regex regex = new Regex(@"(>>>----->>)|(>>----->)|(>----->)");
            int small = 0;
            int medium = 0;
            int large = 0;
            for (int i = 0; i < 4; i++)
            {
                input = Console.ReadLine();
                if (regex.IsMatch(input))
                {
                    MatchCollection matches = regex.Matches(input);

                    foreach (Match match in matches)
                    {
                        if (!string.IsNullOrEmpty((match.Groups[1].Value)))
                        {
                            large++;
                        }
                        else if (!string.IsNullOrEmpty(match.Groups[2].Value))
                        {
                            medium++;
                        }
                        else
                        {
                            small++;
                        }
                    }
                }
            }

            long num = long.Parse(String.Concat(small, medium, large));
            string binary = Convert.ToString(num, 2);
            string reversedBinary = new String(binary.Reverse().ToArray());
            num = Convert.ToInt64(string.Concat(binary, reversedBinary), 2);

            Console.WriteLine(num);
        }
    }
}
