using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

//You are part of the server side application team of brand new and promising activity tracking company. 
//Their product "The Spy" is constantly sending data to the server. 
//The data represents the distance walked in meters for every user in format:
//•	24/07/2014 Angel 4600
//Write a program to aggregate the data and print the activity of each user per month. 
//The months should be represented in ascending order. 
//The users should be ordered alphabetically and the data should be represented in the following way: <month>: <user>(<distance>), <user>(<distance>),… 
//For the data above the output should be:
//•	7: Angel(11100), Pesho(3200)

class ActivityTracker
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        SortedDictionary<int, SortedDictionary<string, List<int>>> dic = new SortedDictionary<int, SortedDictionary<string, List<int>>>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            DateTime dt = DateTime.ParseExact(input[0], "dd/MM/yyyy", null);
            if (!dic.ContainsKey(dt.Month))
            {
                dic[dt.Month] = new SortedDictionary<string, List<int>>();
                dic[dt.Month].Add(input[1], new List<int>());
                dic[dt.Month][input[1]].Add(int.Parse(input[2]));
            }
            else
            {
                if (!dic[dt.Month].ContainsKey(input[1]))
                {
                    dic[dt.Month].Add(input[1], new List<int>());
                    dic[dt.Month][input[1]].Add(int.Parse(input[2]));
                }
                else
                {
                    dic[dt.Month][input[1]].Add(int.Parse(input[2]));
                }
            }
        }

        Print(dic);
        Console.WriteLine();
    }

    private static void Print(SortedDictionary<int, SortedDictionary<string, List<int>>> dic)
    {
        
        foreach (var d in dic)
        {
            Console.Write(d.Key + ": ");
            int count = 0;
            foreach (var name in d.Value)
            {
                Console.Write("{0}({1})", name.Key, name.Value.Sum());
                count++;
                if (count < d.Value.Count)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }


}

