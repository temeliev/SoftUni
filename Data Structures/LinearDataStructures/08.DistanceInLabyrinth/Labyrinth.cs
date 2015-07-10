namespace _08.DistanceInLabyrinth
{
    using System;
    using System.Collections.Generic;

    public static class Labyrinth
    {
        private static Queue<Node> queue;

        static Labyrinth()
        {
            queue = new Queue<Node>();
        }

        public static void CalculateDistance(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int len = 0; len < matrix.GetLength(1); len++)
                {
                    if (matrix[row, len] == "*")
                    {
                        queue.Enqueue(new Node(row, len, 0));
                        break;
                    }
                }
            }

            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Entry point is missing!");
            }

            while (queue.Count > 0)
            {
                var currentNode = queue.Peek();
                int row = currentNode.X;
                int col = currentNode.Y;
                int pos = currentNode.Position;

                List<Node> directions = new List<Node>()
                                        {
                                            new Node(row + 1, col, pos),
                                            new Node(row - 1, col, pos),
                                            new Node(row, col + 1, pos),
                                            new Node(row, col - 1, pos)
                                        };

                for (int i = 0; i < directions.Count; i++)
                {
                    if (CheckBounds(directions[i].X, directions[i].Y, matrix.GetLength(0)) && matrix[directions[i].X, directions[i].Y] == "0")
                    {
                        matrix[directions[i].X, directions[i].Y] = (pos + 1).ToString();
                        queue.Enqueue(new Node(directions[i].X, directions[i].Y, pos + 1));
                    }
                }

                queue.Dequeue();
            }

            SetUnreachablePositions(matrix);
        }

        public static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int len = 0; len < matrix.GetLength(1); len++)
                {
                    Console.Write(matrix[row, len] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void SetUnreachablePositions(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int len = 0; len < matrix.GetLength(1); len++)
                {
                    if (matrix[row, len] == "0")
                    {
                        matrix[row, len] = "u";
                    }
                }
            }
        }

        private static bool CheckBounds(int row, int col, int size)
        {
            if (row >= 0 && col >= 0 && row < size && col < size)
            {
                return true;
            }

            return false;
        }

        private class Node
        {
            public Node(int x, int y, int position)
            {
                this.X = x;
                this.Y = y;
                this.Position = position;
            }

            public int X { get; private set; }

            public int Y { get; private set; }

            public int Position { get; private set; }
        }
    }
}
