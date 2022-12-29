public class Circle : Shape
{
    private double _radius = 1.0;
    public const double PI = 3.14;

    public Circle()
    {

    }
    public Circle(double radius)
    {
        _radius = radius;
    }
    public Circle(double radius, string color, bool filled)
    : base (color, filled)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public void  SetRadius(double radius)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return (_radius * _radius) * PI;
    }
    public override double GetPerimeter()
    {
        return 2*PI*_radius;
    }
    public override string ToString()
    {
        return $"Circle: {base.ToString()} {_radius}";
    }
}