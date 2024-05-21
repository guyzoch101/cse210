public class Triangle : Shape
{
    private double _width;
    private double _height;

    public Triangle(double width, double height) : base("Triangle")
    {
        _width = width;
        _height = height;
    }

    // Unique implementation of GetArea as required by the parent class
    public override double GetArea()
    {
        return 0.5 * _width * _height;
    }
}