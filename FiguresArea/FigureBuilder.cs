using FiguresArea.Shapes;

namespace FiguresArea;

public class FigureBuilder : Figure
{
    private readonly Figure _figure;
    public FigureBuilder(Figure figure) => _figure = figure;

    public FigureBuilder(double radius)=> _figure = new Circle(radius);

    public FigureBuilder(double firstSide, double secondSide, double thirdSide)
    {
        _figure = new Triangle(firstSide, secondSide, thirdSide);
    }

    public override double GetSquare() => _figure.GetSquare();
    public override string GetInfo() => _figure.GetInfo();

    public Figure GetFigure() => _figure;

    public static Triangle CreateTriangle(
        double firstSide,
        double secondSide,
        double thirdSide)
        => new (firstSide, secondSide, thirdSide);

    public static Circle CreateCircle(double radius) => new (radius);

}
