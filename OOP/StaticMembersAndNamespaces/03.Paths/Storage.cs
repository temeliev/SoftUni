using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _03.Paths
{
    public static class Storage
    {
        public static void SaveFile(string filePath, Path3D path)
        {
            if (File.Exists(filePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var p in path.Points)
                    {
                        writer.WriteLine(p.ToString());
                    }
                }
            }
        }

        public static Path3D LoadFile(string filePath)
        {
            List<Point3D> points = new List<Point3D>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string result = reader.ReadLine();

                while (result != null)
                {
                    string[] test = result.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    Point3D point = new Point3D();
                    point.X = double.Parse(test[0].Trim().Split()[2]);
                    point.Y = double.Parse(test[1].Trim().Split()[2]);
                    point.Z = double.Parse(test[2].Trim().Split()[2]);
                    points.Add(point);

                    result = reader.ReadLine();
                }
            }

            var path = new Path3D();
            path.Points = points;

            return path;
        }
    }
}
