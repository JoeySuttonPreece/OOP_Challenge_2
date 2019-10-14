using System;
using NUnit.Framework;
using ShapeLib;

namespace ShapeTests
{
    public class Tests
    {
        [TestCase(5, 25, 20)]
        [TestCase(15, 225, 60)]
        [TestCase(7, 49, 28)]
        public void SquareTest(int sideLength, int area, int perimeter)
        {
            Square square = new Square(sideLength);

            Assert.AreEqual(area, square.GetArea());
            Assert.AreEqual(perimeter, square.GetPerimeter());
        }

        [TestCase(5, 10, 50, 30)]
        [TestCase(4, 6, 24, 20)]
        [TestCase(9, 7, 63, 32)]
        public void RectangleTest(int width, int height, int area, int perimeter)
        {
            Rectangle rectangle = new Rectangle(width, height);

            Assert.AreEqual(area, rectangle.GetArea());
            Assert.AreEqual(perimeter, rectangle.GetPerimeter());
        }

        [TestCase(5, 10.83, 15)]
        [TestCase(15, 97.43, 45)]
        [TestCase(7, 21.22, 21)]
        public void EquilateralTest(int sideLength, double area, double perimeter)
        {
            Equilateral equilateral = new Equilateral(sideLength);
            
            Assert.AreEqual(area, Math.Round(equilateral.GetArea(), 2));
            Assert.AreEqual(perimeter, Math.Round(equilateral.GetPerimeter(), 2));
        }

        [TestCase(5, 10, 25, 26.18)]
        [TestCase(4, 6, 12, 17.21)]
        [TestCase(9, 7, 31.5, 27.4)]
        public void RightAngleTest(int width, int height, double area, double perimeter)
        {
            RightAngle rightAngle = new RightAngle(width, height);
            rightAngle.SetHypotenuse();

            Assert.AreEqual(area, Math.Round(rightAngle.GetArea(), 2));
            Assert.AreEqual(perimeter, Math.Round(rightAngle.GetPerimeter(), 2));
        }

        // these expected results are wrong
        [TestCase(5, 78.55, 31.42)]
        [TestCase(15, 706.95, 94.26)]
        [TestCase(7, 153.96, 43.99)]
        public void CircleTest(int sideLength, double area, double perimeter)
        {
            Circle circle = new Circle();
            circle.Radius = sideLength;

            Assert.AreEqual(area, Math.Round(circle.GetArea(), 2));
            Assert.AreEqual(perimeter, Math.Round(circle.GetPerimeter(), 2));
        }

        [TestCase(typeof(Square))]
        [TestCase(typeof(Rectangle))]
        [TestCase(typeof(Equilateral))]
        [TestCase(typeof(RightAngle))]
        [TestCase(typeof(Circle))]
        public void InterfaceTest(Type type)
        {
            Assert.IsTrue(typeof(IShapeCalc).IsAssignableFrom(type));
        }
    }
}