public class Circle : Shape
{
    private double _radius;

    public Circle(double radius) : base("Circle")
    {
        _radius = radius;
    }

    // Unique implementation of GetArea as required by the parent class
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}