using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(10, "Red");
        Console.WriteLine($"Color: {square.GetColor()}");
        Console.WriteLine($"Area: {square.GetArea()}");
    }
}