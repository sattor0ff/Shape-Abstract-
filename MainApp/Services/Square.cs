public class Square : Shape
{
    private double _side;
    public Square()
    {

    }
    public Square(double side)
    {
        _side = side;
    }
    public Square(double side, string color, bool filled)
    : base(color,filled)
    {
        _side = side;
    }
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }
    public override double GetArea( )
    {
        return _side * _side;
    }
    public override double GetPerimeter()
    {
        return 4 * _side;
    }
    public override string ToString()
    {
        return $"Square: {base.ToString()} {_side}";
    }
}