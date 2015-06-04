using System;
 
namespace _01.Point3D
{
    class MainClass
    {
        static void Main()
        {
            Point3D point = new Point3D(1, 2, 3);
            Console.WriteLine(point);
            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
