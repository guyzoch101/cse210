using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square(10, "Red");
        shapes.Add(square);

        Rectangle rectangle = new Rectangle(2, 5, "Blue");
        shapes.Add(rectangle);

        Circle circle = new Circle(7, "Black");
        shapes.Add(circle);

        foreach(Shape shape in shapes) {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}