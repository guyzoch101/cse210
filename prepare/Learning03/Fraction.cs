public class Fraction {
    private int _top;
    private int _bottom;

    public Fraction() {
        // sets default value to 1/1 when no parameters are passed in
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString() {
        string fractionString = $"{_top}/{_bottom}";

        return fractionString;
    }

    public double GetDeciamlValue() {
        double decimalValue = (double)_top / (double)_bottom;

        return decimalValue;
    }
}