using Mindbox_tt;

namespace Mindbox_ttTests;

public class TriangleTests
{
    [Fact]
    public void IsRight()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRight);
    }
    
    [Fact]
    public void IsNotRight()
    {
        var triangle = new Triangle(3, 4, 6);
        Assert.False(triangle.IsRight);
    }
    
    [Fact]
    public void Area()
    {
        Figure triangle = new Triangle(3, 4, 5); // Вычисление площади фигуры без знания типа фигуры в compile-time

        Assert.Equal(6, triangle.ComputeArea());
    }
    
    [Fact]
    public void DegenerateTriangleNegativeSide()
    {
        Assert.Throws<DegenerateFigureException>(() => { _ = new Triangle(-3, 4, 5);});
        Assert.Throws<DegenerateFigureException>(() => { _ = new Triangle(3, -4, 5);});
        Assert.Throws<DegenerateFigureException>(() => { _ = new Triangle(3, 4, -5);});
    }

    [Fact]
    public void DegenerateTriangleImpossibleSides()
    {
        Assert.Throws<DegenerateFigureException>(() => { _ = new Triangle(2, 2, 5); });
    }
}