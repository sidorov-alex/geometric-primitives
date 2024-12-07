namespace GeometricPrimitives.Tests;

public class TriangleTest
{
    [Theory]
    [InlineData(0, 1, 1)]
    [InlineData(1, 0, 1)]
    [InlineData(1, 1, 0)]
    public void ConstructorThrowsInvalidArgument(double edgeA, double edgeB, double edgeC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(edgeA, edgeB, edgeC));
    }
    
    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(1, 2, 1)]
    [InlineData(1, 1, 2)]
    public void ConstructorThrowsInvalidArgument_Inequality(double edgeA, double edgeB, double edgeC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(edgeA, edgeB, edgeC));
    }
    
    [Theory]
    [InlineData(5, 12, 13, 30)]
    [InlineData(6, 8, 10, 24)]
    [InlineData(7, 24, 25, 84)]
    public void GetAreaEquals(double edgeA, double edgeB, double edgeC, double expected)
    {
        ITriangle triangle = new Triangle(edgeA, edgeB, edgeC);
        Assert.Equal(triangle.CalcArea(), expected);
    }

    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(5, 12, 13)]
    [InlineData(8, 15, 17)]
    public void IsRightTriangleTrue(double edgeA, double edgeB, double edgeC)
    {
        ITriangle triangle = new Triangle(edgeA, edgeB, edgeC);
        Assert.True(triangle.IsRightTriangle());
    }
    
    [Theory]
    [InlineData(2, 4, 5)]
    [InlineData(2, 12, 13)]
    [InlineData(3, 15, 17)]
    public void IsRightTriangleFalse(double edgeA, double edgeB, double edgeC)
    {
        ITriangle triangle = new Triangle(edgeA, edgeB, edgeC);
        Assert.False(triangle.IsRightTriangle());
    }
}