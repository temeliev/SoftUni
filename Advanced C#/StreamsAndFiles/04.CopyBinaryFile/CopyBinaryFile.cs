using System;
using System.IO;
using System.Text;

//Write a program that copies the contents of a binary file (e.g. image, video, etc.) to another using FileStream. You are not allowed to use the File class or similar helper classes.
class CopyBinaryFile
{
    static void Main()
    {
        using (FileStream source = new FileStream("..//..//Source.jpeg", FileMode.Open))
        {
            byte[] buffer = null;
            buffer = Encoding.UTF8.GetBytes("..//..//Source.jpeg");
            int len = source.Read(buffer, 0, buffer.Length);
            using (FileStream dest = new FileStream("..//..//Destination.jpeg", FileMode.Create))
            {
                dest.Write(buffer, 0, len);
            }
        }
    }
}

