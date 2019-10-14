namespace ShapeLib
{
    public class Square : Quadrilateral
    {
        public Square(double sideLength)
        {
            Side1Length = sideLength;
            Side2Length = sideLength;
            Side3Length = sideLength;
            Side4Length = sideLength;
        }

        public override double GetArea()
        {
            return Side1Length * Side1Length;
        }
    }
}
