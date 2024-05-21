public abstract class Shape
{
    // Common Attributes for all Shapes
    private string _name;

    public Shape(string name)
    {
        _name = name;
    }

    // Common Methods for all Shapes
    public void Display()
    {
        Console.WriteLine(_name);
    }

    // Methods that each child class MUST implement
    public abstract double GetArea();
}