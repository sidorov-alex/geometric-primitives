namespace GeometricPrimitives;

public class Circle : IShape
{
    public double Radius { get; }
    
    public double CalcArea() => Math.PI * Radius * Radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть положительным числом.");
        
        Radius = radius;
    }
}