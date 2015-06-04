using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _03.Paths
{
    public class Path3D
    {
        public Path3D()
        {
            Points = new List<Point3D>();
        }

        public List<Point3D> Points { get; set; }
    }
}
