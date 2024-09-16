using Mindbox_tt;

namespace Mindbox_ttTests;

public class CircleTests
{
    [Fact]
    public void Area()
    {
        const double circleArea = Math.PI * 100;
        var circle = new Circle(10d);
        
        Assert.Equal(circleArea, circle.ComputeArea());
    }
    
    [Fact]
    public void DegenerateCircle()
    {
        Assert.Throws<DegenerateFigureException>(() => { _ = new Circle(-1);});
    }
}