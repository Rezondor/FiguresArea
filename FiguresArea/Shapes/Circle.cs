namespace FiguresArea.Shapes;

public class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius):base("Круг")
    {
        Radius = radius;
    }

    public override double GetSquare()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

}