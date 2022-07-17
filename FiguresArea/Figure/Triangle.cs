namespace FiguresArea.Figure;

public class Triangle : ISquare
{
    public double FirstSide { get; set; }

    public double SecondSide { get; set; }

    public double ThirdSide { get; set; }

    public Triangle(
        double firstSide,
        double secondSide,
        double thirdSide)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public double GetSquare()
    {
        double halfPerimeter = FindPerimetr(FirstSide, SecondSide, ThirdSide) / 2;

        return Math.Sqrt(halfPerimeter *
            (halfPerimeter - FirstSide) *
            (halfPerimeter - SecondSide) *
            (halfPerimeter - ThirdSide));

    }

    public double FindPerimetr(
        double firstSide,
        double secondSide,
        double thirdSide)
    {
        return firstSide + secondSide + thirdSide;
    }

    public bool IsRightTriangle()
    {
        return 
            Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) == Math.Pow(ThirdSide, 2) ||
            Math.Pow(ThirdSide, 2) + Math.Pow(SecondSide, 2) == Math.Pow(SecondSide, 2) ||
            Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2) == Math.Pow(FirstSide, 2);
    }
}
