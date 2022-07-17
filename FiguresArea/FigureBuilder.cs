using FiguresArea.Figure;

namespace FiguresArea;

public class FigureBuilder:ISquare
{
    private ISquare _figure;
    public FigureBuilder(ISquare figure) => _figure = figure;

    public FigureBuilder(double radius)
    {
        _figure = new Circle(radius);
    }

    public FigureBuilder(double firstSide, double secondSide, double thirdSide)
    {
        _figure = new Triangle(firstSide, secondSide, thirdSide); 
    }

    public double GetSquare() => _figure.GetSquare();

    public ISquare GetFigure()
    {
        return _figure;
    }
    
}
