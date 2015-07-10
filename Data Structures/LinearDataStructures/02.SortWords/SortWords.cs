namespace _02.SortWords
{
    using System;
    using System.Collections.Generic;
    
    class SortWords
    {
        static void Main()
        {
            List<string> words = new List<string>(Console.ReadLine().Split());
            words.Sort();
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
