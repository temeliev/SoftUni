namespace _08.DistanceInLabyrinth
{
    using System;

    class MainClass
    {
        static void Main()
        {
            string[,] matrix = 
        {
            {"0", "0", "0", "x", "0", "x"},
            {"0", "x", "0", "x", "0", "x"},
            {"0", "*", "x", "0", "x", "0"},
            {"0", "x", "0", "0", "0", "0"},
            {"0", "0", "0", "x", "x", "0"},
            {"0", "0", "0", "x", "0", "x"},
        };

            Labyrinth.CalculateDistance(matrix);
            Labyrinth.PrintMatrix(matrix);
            Console.WriteLine();

            matrix = new string[,]
        {
            {"0", "0", "0", "x", "0", "x"},
            {"0", "x", "0", "x", "*", "x"},
            {"0", "x", "x", "0", "x", "0"},
            {"0", "x", "0", "0", "0", "0"},
            {"0", "0", "0", "x", "x", "0"},
            {"0", "0", "0", "x", "0", "x"},
        };

            Labyrinth.CalculateDistance(matrix);
            Labyrinth.PrintMatrix(matrix);
            Console.WriteLine();

            matrix = new string[,]
        {
            {"0", "0", "0", "x", "0", "x"},
            {"0", "x", "0", "x", "0", "x"},
            {"0", "x", "x", "0", "x", "0"},
            {"0", "x", "0", "0", "0", "0"},
            {"0", "0", "*", "x", "x", "0"},
            {"0", "0", "0", "x", "0", "x"},
        };

            Labyrinth.CalculateDistance(matrix);
            Labyrinth.PrintMatrix(matrix);
            Console.WriteLine();
        }
    }
}
