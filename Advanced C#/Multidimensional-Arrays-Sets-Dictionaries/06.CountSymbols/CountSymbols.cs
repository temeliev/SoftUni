using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads some text from the console and counts the occurrences of each character in it. 
//Print the results in alphabetical (lexicographical order).
class CountSymbols
{
    static void Main()
    {
        List<char> charList = new List<char>();
        charList.AddRange(Console.ReadLine().ToCharArray());
        SortedSet<char> distinctedChars = new SortedSet<char>();
        charList.ForEach(x => distinctedChars.Add(x));

        foreach (var item in distinctedChars)
        {
            Console.WriteLine("{0} : {1} time/s", item, charList.Count(x => x == item));
        }

    }
}

