namespace FiguresArea.Shapes;

public class Triangle : Figure
{
    public double FirstSide { get; set; }

    public double SecondSide { get; set; }

    public double ThirdSide { get; set; }

    public Triangle(
        double firstSide,
        double secondSide,
        double thirdSide):base("Треугольник")
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public override double GetSquare()
    {
        double halfPerimeter = GetPerimetr(FirstSide, SecondSide, ThirdSide) / 2;

        return Math.Sqrt(halfPerimeter *
            (halfPerimeter - FirstSide) *
            (halfPerimeter - SecondSide) *
            (halfPerimeter - ThirdSide));

    }

    public static double GetPerimetr(
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
