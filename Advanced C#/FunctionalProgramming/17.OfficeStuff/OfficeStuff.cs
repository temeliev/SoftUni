using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.OfficeStuff
{
    class OfficeStuff
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, Dictionary<string, List<int>>> dic = new SortedDictionary<string, Dictionary<string, List<int>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '|', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string firm = input[0];
                string product = input[2];
                int amount = int.Parse(input[1]);

                if (!dic.ContainsKey(firm))
                {
                    dic[firm] = new Dictionary<string, List<int>>();
                    dic[firm][product] = new List<int>();
                    dic[firm][product].Add(amount);
                }
                else
                {
                    if (!dic[firm].ContainsKey(product))
                    {
                        dic[firm][product] = new List<int>();
                        dic[firm][product].Add(amount);
                    }
                    else
                    {
                        dic[firm][product].Add(amount);
                    }
                }

            }

            foreach (var item in dic)
            {
                int count = 0;
                Console.Write("{0}: ", item.Key);

                foreach (var val in item.Value)
                {
                    if (count < item.Value.Count - 1)
                    {
                        Console.Write("{0}-{1}, ", val.Key, val.Value.Sum());
                    }
                    else
                    {
                        Console.Write("{0}-{1}", val.Key, val.Value.Sum());
                    }

                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
