using System;

namespace ShapeLib
{
    public class RightAngle : Triangle, IShapeCalc
    {
        public RightAngle(double side1Length, double side2Length)
        {
            Side1Length = side1Length;
            Side2Length = side2Length;
        }

        public double GetArea()
        {
            return Side1Length * Side2Length / 2;
        }

        public double GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length;
        }

        public void SetHypotenuse()
        {
            Side3Length = Math.Sqrt(Side1Length * Side1Length + Side2Length * Side2Length);
        }
    }
}
