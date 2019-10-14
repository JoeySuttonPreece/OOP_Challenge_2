namespace ShapeLib
{
    public abstract class Quadrilateral : Shape, IShapeCalc
    {
        public double Side1Length;
        public double Side2Length;
        public double Side3Length;
        public double Side4Length;

        public abstract double GetArea();

        public double GetPerimeter()
        {
            return Side1Length + Side2Length + Side3Length + Side4Length;
        }
    }
}
