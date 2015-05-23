using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//Modify your previous program to recursively traverse the sub-directories of the starting directory as well.
class FullDirectoryTraversal
{
    private static Dictionary<string, Dictionary<string, double>> _dic;
    static void Main()
    {
        _dic = new Dictionary<string, Dictionary<string, double>>();
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\report.txt";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Няма файл report.txt на desktop-a!");
        }
        else
        {
            string directory = File.ReadAllText(filePath);
            AddFiles(directory);
            CheckSubDirectories(directory);

            Print(_dic);
        }
    }

    private static void CheckSubDirectories(string startDirectory)
    {
        var directories = Directory.GetDirectories(startDirectory);
        if (directories.Length == 0)
        {
            return;
        }

        foreach (var dir in directories)
        {
            CheckSubDirectories(dir);
            AddFiles(dir);
        }

    }

    private static void AddFiles(string directory)
    {
        var files = Directory.GetFiles(directory);

        foreach (var f in files)
        {
            string fileName = Path.GetFileNameWithoutExtension(f);
            string ext = Path.GetExtension(f);
            FileInfo info = new FileInfo(f);
            double size = info.Length / 1024d;
            if (!_dic.ContainsKey(ext))
            {
                _dic[ext] = new Dictionary<string, double>();
                _dic[ext].Add(fileName, size);
            }
            else
            {
                if (!_dic[ext].ContainsKey(fileName))
                {
                    _dic[ext].Add(fileName, size);
                }
            }
        }
    }

    private static void Print(Dictionary<string, Dictionary<string, double>> dic)
    {
        foreach (var item in dic.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            Console.WriteLine(item.Key);
            foreach (var d in item.Value.OrderBy(x => x.Value))
            {
                Console.WriteLine("--{0}{1} - {2:f3}kb", d.Key, item.Key, d.Value);
            }
        }
    }
}

