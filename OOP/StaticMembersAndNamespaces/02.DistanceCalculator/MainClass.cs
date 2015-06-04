using System;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    class MainClass
    {
        static void Main()
        {
            Point3D pointA = new Point3D(-7, -4, 3);
            Point3D pointB = new Point3D(17, 6, 2.5);
            Console.WriteLine("Distance: {0}", DistanceCalculator.CalculateDistance(pointA, pointB));
        }
    }
}
