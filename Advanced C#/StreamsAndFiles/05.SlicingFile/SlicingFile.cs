using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SlicingFile
{
    static void Main()
    {
        Console.Write("Enter number of parts: ");
        int parts = int.Parse(Console.ReadLine());
        Console.Write("Enter file path: ");
        string inputFolderPath = Console.ReadLine(); // "..//..//source.jpg";
        Console.Write("Enter output directory: ");
        string outputDirectory = Console.ReadLine(); // Path.GetFullPath("..//..//");
        Slice(inputFolderPath, outputDirectory, parts);
        List<string> files = new List<string>();
        string extension = Path.GetExtension(inputFolderPath);
        files.AddRange(Directory.GetFiles(outputDirectory, "*" + extension).ToList());
        Assemble(files, outputDirectory + "\\assembled" + extension);
    }

    private static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        byte[] buffer;
        FileStream fileStream = new FileStream(sourceFile, FileMode.Open);
        try
        {
            int length = (int)fileStream.Length;
            buffer = new byte[length];
            int count;
            int sum = 0;

            while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
            {
                sum += count;
            }
        }
        finally
        {
            fileStream.Close();
        }

        int partSize = (int)Math.Ceiling((double)(buffer.Length / parts));
        int fileOffset = 0;
        string currPartPath = string.Empty;
        int sizeRemaining = buffer.Length;
        string extension = Path.GetExtension(sourceFile);
        for (int i = 0; i < parts; i++)
        {
            currPartPath = destinationDirectory + "\\" + "part - " + i + extension;

            if (!File.Exists(currPartPath))
            {
                FileStream fsPart = new FileStream(currPartPath, FileMode.CreateNew);
                try
                {
                    sizeRemaining = buffer.Length - (i * partSize);

                    if (sizeRemaining < partSize)
                    {
                        partSize = sizeRemaining;
                    }

                    fsPart.Write(buffer, fileOffset, partSize);
                    fileOffset += partSize;
                }
                finally
                {
                    fsPart.Close();
                }
            }
        }
    }

    private static void Assemble(List<string> files, string destinationDirectory)
    {
        FileStream fsSource = new FileStream(destinationDirectory, FileMode.Append);
        try
        {
            foreach (var file in files)
            {
                if (!file.Contains("part"))
                {
                    continue;
                }

                byte[] buffer;
                FileStream fsDest = new FileStream(file, FileMode.Open);
                int len = (int)fsDest.Length;
                buffer = new byte[len];
                int sum = 0;
                int count;
                while ((count = fsDest.Read(buffer, sum, len - sum)) > 0)
                {
                    sum += count;
                }
                fsDest.Close();
                fsSource.Write(buffer, 0, buffer.Length);
            }
        }
        finally
        {
            fsSource.Close();
        }
    }
}

