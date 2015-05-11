using System;
//On de_dust2 terrorists have planted a bomb (or possibly several of them)! Write a program that sets those bombs off!
//A bomb is a string in the format |...|. When set off, the bomb destroys all characters inside. 
//The bomb should also destroy n characters to the left and right of the bomb. 
//n is determined by the bomb power (the last digit of the ASCII sum of the characters inside the bomb). 
//Destroyed characters should be replaced by '.' (dot). For example, we are given the following text:
//prepare|yo|dong
//The bomb is |yo|. We get the bomb power by calculating the last digit of the sum: y (121) + o (111) = 232. 
//The bomb explodes and destroys itself and 2 characters to the left and 2 characters to the right. The result is:
//prepa........ng

class TerroristsWin
{
    static void Main()
    {
        string input = Console.ReadLine();
        bool isCalculating = false;
        int sum = 0;
        int bombLength = 0;
        int bombIndex = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '|')
            {
                isCalculating = !isCalculating;
                bombIndex = i;
                continue;
            }

            if (isCalculating)
            {
                sum += input[i];
                bombLength++;
            }
            else
            {
                if (sum > 0)
                {
                    int digit = sum % 10;
                    int startIndex = bombIndex - digit - bombLength - 1;
                    input = input.Remove(startIndex, bombLength + (digit * 2) + 2);
                    input = input.Insert(startIndex, new String('.', bombLength + (digit * 2) + 2));
                    sum = 0;
                    bombIndex = 0;
                    bombLength = 0;
                }
            }
        }

        Console.WriteLine(input);
    }
}

