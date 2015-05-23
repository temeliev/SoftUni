using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads a sequence of n integers and calculates and prints the frequencies of all couples of two consecutive numbers. 
//For example, for the input sequence { 3 4 2 3 4 2 1 12 2 3 4 }, we have 10 couples (6 distinct), shown on the right with their occurrence counts and frequencies (in percentage).
class CouplesFrequency
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        HashSet<string> distinctedCouples = new HashSet<string>();
        List<string> allCouples = new List<string>();

        for (int i = 1; i < input.Length; i++)
        {
            string str = input[i - 1] + " " + input[i];
            distinctedCouples.Add(str);
            allCouples.Add(str);
        }

        foreach (var couple in distinctedCouples)
        {
            int count = allCouples.Count(x => x == couple);
            Console.WriteLine("{0} -> {1:f2}%", couple, (count * 100d) / allCouples.Count);
        }
    }
}

