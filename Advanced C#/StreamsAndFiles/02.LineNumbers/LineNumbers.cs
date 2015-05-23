using System;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file. 
//Use StreamReader in combination with StreamWriter.
class LineNumbers
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("..//..//SourceFile.txt"))
        {
            using (StreamWriter writer = new StreamWriter("..//..//DestinationFile.txt"))
            {
                string result = reader.ReadLine();
                int count = 1;

                while (result != null)
                {
                    writer.WriteLine(count + "." + result);
                    count++;
                    result = reader.ReadLine();
                }

            }

        }
    }
}

