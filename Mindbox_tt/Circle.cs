namespace Mindbox_tt;

public class Circle : Figure
{
    public double Radius { get; }

    public Circle(double r)
    {
        if (r < 0)
        {
            throw new DegenerateFigureException("Circle cannot have a negative radius");
        }
        Radius = r;
    }
    
    public override double ComputeArea()
    {
        return Math.PI * Radius * Radius;
    }
}