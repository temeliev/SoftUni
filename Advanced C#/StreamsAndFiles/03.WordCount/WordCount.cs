using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file text.txt. 
//Matching should be case-insensitive.
//Write the results in file results.txt. 
//Sort the words by frequency in descending order. Use StreamReader in combination with StreamWriter.

class WordCount
{
    static void Main()
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        StreamReader reader = new StreamReader("..//..//Text.txt");
        string[] text = reader.ReadToEnd().Split(new char[] { '-', '.', '\r', ' ', '\n', ',', '?', '!', '…' }, StringSplitOptions.RemoveEmptyEntries);
        reader.Close();


        using (StreamReader wordReader = new StreamReader("..//..//Words.txt"))
        {
            string word = wordReader.ReadLine();

            while (word != null)
            {
                dic[word] = text.Count(x => x.ToLower() == word);
                word = wordReader.ReadLine();
            }
        }

        using (StreamWriter writer = new StreamWriter("..//..//Result.txt"))
        {
            foreach (var d in dic.OrderByDescending(x => x.Value))
            {
                writer.WriteLine(d.Key + " - " + d.Value);
            }
        }
    }
}

