namespace ShapeLib
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(double width, double height)
        {
            Side1Length = width;
            Side2Length = height;
            Side3Length = width;
            Side4Length = height;
        }

        public override double GetArea()
        {
            return Side1Length * Side2Length;
        }
    }
}
