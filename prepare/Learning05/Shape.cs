public abstract class Shape {
    protected string _color;

    public Shape(string color) {
        _color = color;
    }

    public string GetColor() {
        return _color;
    }

    public void SetColor(string color) {
        _color = color;
    }

    public abstract double GetArea(); // declare it as abstract to keep the base GetArea method empty
}