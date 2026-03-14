
class Circle
{
    private double _radius;

    public double GetRaidius()
    {
        return _radius;
    }

    public void SetRadoius(double radius)
    {
        _radius = radius;
    }
    public double GetArea()
    {
        Math.Pow(_radius, 2);
    }

    public double GetDiameter()
    {
        return 2 * _radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * _radius;
    }
}