using System;
using System.Security;
using System.Text;

namespace _14.TextGravity
{
    class TextGravity
    {
        static void Main()
        {
            int cols = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int rows = (int)Math.Ceiling(input.Length / (double)cols);
            char[,] table = new char[rows, cols];
            int count = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (count == input.Length)
                    {
                        table[row, col] = ' ';
                    }
                    else
                    {
                        table[row, col] = input[count++];
                    }
                }
            }

            while (count > 0)
            {
                count = 0;
                for (int col = 0; col < cols; col++)
                {
                    for (int row = 1; row < rows; row++)
                    {
                        if (table[row, col] == ' ' && table[row - 1, col] != ' ')
                        {
                            char temp = table[row - 1, col];
                            table[row - 1, col] = table[row, col];
                            table[row, col] = temp;
                            count++;
                        }
                    }
                }

            }

            StringBuilder sb = new StringBuilder();
            sb.Append("<table>");
            for (int row = 0; row < rows; row++)
            {
                sb.Append("<tr>");
                for (int col = 0; col < cols; col++)
                {
                    sb.Append("<td>");
                    sb.Append(SecurityElement.Escape(table[row, col].ToString()));
                    sb.Append("</td>");
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");

            Console.WriteLine(sb.ToString());
        }
    }
}
