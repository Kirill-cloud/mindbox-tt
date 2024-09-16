namespace Mindbox_tt;

public class Triangle : Figure
{
    public double SideA => _sides[0];

    public double SideB => _sides[1];

    public double SideC => _sides[2];

    private readonly double[] _sides;

    public Triangle(double a, double b, double c)
    {
        _sides = [a, b, c];
        if (_sides.Any(x => x < 0))
        {
            throw new DegenerateFigureException("Triangle cannot have a negative side");
        }
        Array.Sort(_sides);
        
        if (SideC > SideA + SideB)
        {
            throw new DegenerateFigureException($"Triangle ({SideA}, {SideB}, {SideC}) is degenerate");
        }
    }

    public bool IsRight => Math.Abs(SideA * SideA + SideB * SideB - SideC * SideC) < Settings.Accuracy;

    public override double ComputeArea()
    {
        var p = (SideA + SideB + SideC) / 2; // p - semiperimeter
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
}