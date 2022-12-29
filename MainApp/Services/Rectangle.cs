public class Rectangle : Shape
{
    private double _width = 1.0;
    private double _length = 1.0;

    public Rectangle()
    {

    }
    public Rectangle(double width, double length)
    {
        _width = width;
        _length = length;
    }
    public Rectangle(double width, double length, string color, bool filled)
    :base (color, filled)
    {
        _width = width;
        _length = length;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }
    public override double GetArea()
    {
        return _width * _length;
    }
    public override double GetPerimeter()
    {
        return (_width + _length) * 2;
    }
    public override string ToString()
    {
        return $"Rectangle: {base.ToString()} ";
    }

}