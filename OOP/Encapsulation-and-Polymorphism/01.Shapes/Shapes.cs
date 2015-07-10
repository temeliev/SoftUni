using System;

namespace _01.Shapes
{
    class Shapes
    {
        static void Main()
        {
            IShape[] shapeArray = new IShape[3];

            shapeArray[0] = new Triangle(15, 9);
            shapeArray[1] = new Rectangle(4, 6);
            shapeArray[2] = new Circle(4);

            foreach (var shape in shapeArray)
            {
                Console.WriteLine("{0} perimeter is {1}", shape.GetType().Name, shape.CalculatePerimeter());
                Console.WriteLine("{0} area is {1}", shape.GetType().Name, shape.CalculateArea());
            }
        }
    }
}
