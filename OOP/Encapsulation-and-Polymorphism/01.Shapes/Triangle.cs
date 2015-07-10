using System;

namespace _01.Shapes
{
    public class Triangle : BasicShape
    {
        public Triangle(double width, double height) : base(width, height) { }

        public override double CalculateArea()
        {
            return 0.5 * this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            double thirdSide = Math.Sqrt((this.Width * this.Width) - (this.Height * this.Height));
            return this.Width + this.Height + thirdSide;
        }
    }
}
