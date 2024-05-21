public class Square : Shape
{
    private double _side;

    public Square(double side) : base("Square")
    {
        _side = side;
    }

    // Unique implementation of GetArea as required by the parent class
    public override double GetArea()
    {
        return _side * _side;
    }
}