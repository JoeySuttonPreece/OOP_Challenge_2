namespace ShapeLib
{
    /// <summary>
    /// This interface provides a contract for classes to provide geometric calculations: area, perimeter.
    /// </summary>
    public interface IShapeCalc
    {
        double GetArea();
        double GetPerimeter();
    }
}
