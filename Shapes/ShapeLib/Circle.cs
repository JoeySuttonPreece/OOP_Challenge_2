namespace ShapeLib
{
    public class Circle : Shape, IShapeCalc
    {
        public readonly double PI = 3.14159265359;
        public double Radius;

        public double GetArea()
        {
            return PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * PI * Radius;
        }
    }
}
