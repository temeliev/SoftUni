using System;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines. Line numbers starts from 0. Use StreamReader.
class OddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("..//..//Test.txt"))
        {
            string result = reader.ReadLine();
            int count = 1;
            while (result != null)
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine(result);

                }
                count++;
                result = reader.ReadLine();
            }
        }
    }
}
