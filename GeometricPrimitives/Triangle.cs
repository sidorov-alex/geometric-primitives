namespace GeometricPrimitives;

public class Triangle : ITriangle
{
    public double EdgeA { get; }
    public double EdgeB { get; }
    public double EdgeC { get; }

    public Triangle(double edgeA, double edgeB, double edgeC)
    {
        if (edgeA <= 0 || edgeB <= 0 || edgeC <= 0)
            throw new ArgumentException("Длины сторон треугольника должны быть положительными числами.");
        
        // Проверка на Неравенство треугольника.
        if (edgeA >= edgeB + edgeC || edgeB >= edgeA + edgeC || edgeC >= edgeA + edgeB)
            throw new ArgumentException("Неверно заданы стороны треугольника.");
        
        EdgeA = edgeA;
        EdgeB = edgeB;
        EdgeC = edgeC;
    }
    
    public double CalcArea()
    {
        // Вычисляем по формуле Герона.
        var s = (EdgeA + EdgeB + EdgeC) / 2d;
        return Math.Sqrt(s * (s - EdgeA) * (s - EdgeB) * (s - EdgeC));
    }

    /// <summary>
    /// Погрешность при вычислениях в методе IsRightTriangle().
    /// </summary>
    public const double DefaultIsRightTriangleTolerance = 1e-6;

    public bool IsRightTriangle() => IsRightTriangle(DefaultIsRightTriangleTolerance);
    
    public bool IsRightTriangle(double tolerance)
    {
        var a2 = EdgeA * EdgeA;
        var b2 = EdgeB * EdgeB;
        var c2 = EdgeC * EdgeC;

        // Проверяем по теореме Пифагора любую из комбинаций.
        return Math.Abs(a2 + b2 - c2) < tolerance ||
               Math.Abs(a2 + c2 - b2) < tolerance ||
               Math.Abs(b2 + c2 - a2) < tolerance;
    }
}