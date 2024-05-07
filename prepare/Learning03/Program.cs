using System;

class Program
{
    static void Main(string[] args)
    {
        // fraction 1: no parameters passed in
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDeciamlValue());

        // fraction 2: a whole number (numerator = whole number, denominator = 1)
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDeciamlValue());

        // fraction 3: a fraction
        Fraction fraction3 = new Fraction(1, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDeciamlValue());
    }
}