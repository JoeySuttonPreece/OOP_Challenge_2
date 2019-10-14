using System;

namespace ShapeLib
{
    public class Equilateral : Triangle, IShapeCalc
    {
        public Equilateral(double sideLength)
        {
            Side1Length = sideLength;
            Side2Length = sideLength;
            Side3Length = sideLength;
        }

        public double GetArea()
        {
            return Math.Sqrt(3) * Side1Length * Side1Length / 4;
        }

        public double GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length;
        }
    }
}
