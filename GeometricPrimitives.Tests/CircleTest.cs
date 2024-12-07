namespace GeometricPrimitives.Tests;

public class CircleTest
{
    [Fact]
    public void ConstructorThrowsInvalidArgument()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }

    [Fact]
    public void GetAreaEquals()
    {
        IShape circle = new Circle(5);
        var actual = circle.CalcArea();
        
        var expected = Math.PI * 5 * 5;
        Assert.Equal(expected, actual);
    }
}