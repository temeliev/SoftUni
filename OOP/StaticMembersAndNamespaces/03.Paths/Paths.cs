using System;
using _01.Point3D;

namespace _03.Paths
{
    class Paths
    {
        static void Main()
        {
            Path3D path = new Path3D();
            path.Points.Add(new Point3D(2.3, 2, 6));
            path.Points.Add(new Point3D(5.2, 11, 3));
            path.Points.Add(new Point3D(7.7, 2.3, 6.78));
            Storage.SaveFile("..//..//test.txt", path);
            var newPath = Storage.LoadFile("..//..//test.txt");
            newPath.Points.ForEach(x => Console.WriteLine(x));
        }
    }
}
