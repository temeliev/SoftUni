using System;

namespace _01.Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The radius is negative!");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
