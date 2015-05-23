using System;
//In geometry, a disk is the region in a plane bounded by a circle (it also includes the circle itself). 
//Your task is to print a disk on the console by a given radius R in a square field of size N x N (see the examples below).
class Disk
{
    private static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());
        int centerX = fieldSize / 2;
        int centerY = fieldSize / 2;
        
        for (int row = 0; row < fieldSize; row++)
        {
            for (int col = 0; col < fieldSize; col++)
            {
                int x = row - centerX;
                int y = col - centerY;
                double distanceToCenter = Math.Sqrt(x * x + y * y);
                if (distanceToCenter <= radius)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}

