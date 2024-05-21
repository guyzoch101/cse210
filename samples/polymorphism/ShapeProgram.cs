class Program
{
    // Simple menu to test out the shape classes.
    static void Main(string[] args)
    {
        // Create a list of Shapes (which could include Circles, Squares, and Triangles mixed together)
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(10.0));
        shapes.Add(new Square(2.5));
        shapes.Add(new Circle(3.9));
        shapes.Add(new Triangle(5,10));
        shapes.Add(new Triangle(2,4));
        shapes.Add(new Square(9));

        // Display all of them - This will call the function in the Shape class
        foreach (Shape s in shapes)
        {
            s.Display();
        }

        // Show the aeras of them - This will call the function in the child classes
        foreach (Shape s in shapes)
        {
            double area = s.GetArea();
            Console.WriteLine(area);
        }
    }
}