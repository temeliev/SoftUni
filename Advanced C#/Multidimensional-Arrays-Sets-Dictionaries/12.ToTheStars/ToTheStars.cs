using System;
using System.Collections.Generic;
using System.Linq;

class ToTheStars
{
    static void Main()
    {
        string[] input;
        List<Star> stars = new List<Star>();
        for (int i = 0; i < 3; i++)
        {
            input = Console.ReadLine().Split();
            Star star = new Star();
            star.Name = input[0].ToLower();
            star.X = double.Parse(input[1]);
            star.Y = double.Parse(input[2]);
            stars.Add(star);
        }

        input = Console.ReadLine().Split();
        double startX = double.Parse(input[0]);
        double startY = double.Parse(input[1]);
        input = Console.ReadLine().Split();
        int distance = int.Parse(input[0]);

        for (int i = 0; i <= distance; i++)
        {
            var result =
                stars.Where(x => (x.X - 1 <= startX && startX <= x.X + 1) && (x.Y - 1 <= startY && startY <= x.Y + 1))
                    .Select(x => x.Name).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(result))
            {
                Console.WriteLine("space");
            }
            else
            {
                Console.WriteLine(result);
            }

            startY++;
        }

    }
}

public class Star
{
    public string Name { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
}

