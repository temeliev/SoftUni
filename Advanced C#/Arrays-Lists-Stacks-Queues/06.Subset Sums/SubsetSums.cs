using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads from the console a number N and an array of integers given on a single line. 
//Your task is to find all subsets within the array which have a sum equal to N and print them on the console (the order of printing is not important). 
//Find only the unique subsets by filtering out repeating numbers first. 
//In case there aren't any subsets with the desired sum, print "No matching subsets."
class SubsetSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        List<string> result = new List<string>();

        for (int i = 0; i < Math.Pow(2, input.Length); i++) //n^2 all posible subsets
        {
            string[] combination = new string[input.Length];
            for (int j = 0; j < input.Length; j++)
            {
                if ((i & (1 << (input.Length - j - 1))) != 0)
                {
                    combination[j] = input[j];
                }
            }
            int sum = 0;
            foreach (var c in combination)
            {
                if (c != null)
                {
                    sum += int.Parse(c);
                }
            }

            if (sum == n)
            {
                string str = string.Join(" ", combination.Where(x => x != null).OrderBy(x => x));
                if (!string.IsNullOrWhiteSpace(str) && !result.Contains(str))
                {
                    result.Add(str);
                }
            }
        }

        if (result.Count == 0)
        {
            Console.WriteLine("No matching subsets.");
        }
        else
        {
            foreach (var item in result)
            {
                var ss = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] ass = Array.ConvertAll(ss, int.Parse);
                Console.WriteLine("{0} = {1}", string.Join(" + ", ass), n);
            }
        }
    }
}

