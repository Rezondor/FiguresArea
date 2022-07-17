namespace FiguresArea.Figure;

public class Circle : ISquare
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetSquare()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}