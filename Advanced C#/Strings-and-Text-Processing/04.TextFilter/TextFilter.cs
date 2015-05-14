using System;
//Write a program that takes a text and a string of banned words. 
//All words included in the ban list should be replaced with asterisks "*", equal to the word's length. 
//The entries in the ban list will be separated by a comma and space ", ".
//The ban list should be entered on the first input line and the text on the second input line. 
class TextFilter
{
    static void Main()
    {
        string[] bannedList = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();

        foreach (var ban in bannedList)
        {
            text = text.Replace(ban, new String('*', ban.Length));
        }

        Console.WriteLine(text);
    }
}

