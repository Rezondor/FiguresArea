
namespace TestGetSquare;

public class CircleSquare
{

    [Fact]
    public void FindCircleArea_Radius_1_Equal_Pi_CreateConstruct()
    {
        var circle = new FigureBuilder(1);

        Assert.Equal(Math.PI, circle.GetSquare());
    }

    [Fact]
    public void FindCircleArea_Radius_1_Equal_Pi_CreateCircle()
    {
        var circle = FigureBuilder.CreateCircle(1);

        Assert.Equal(Math.PI, circle.GetSquare());
    }

    [Fact]
    public void FindCircleArea_Radius_1_Equal_Pi_CreateNewFigure()
    {
        var circle = new FigureBuilder(new Circle(1));

        Assert.Equal(Math.PI, circle.GetSquare());
    }



    [Fact]
    public void FindCircleArea_Radius_5_Equal_Pix25_CreateConstruct()
    {
        var circle = new FigureBuilder(5);

        Assert.Equal(Math.PI * 25, circle.GetSquare());
    }

    [Fact]
    public void FindCircleArea_Radius_5_Equal_Pix25_CreateCircle()
    {
        var circle = FigureBuilder.CreateCircle(5);

        Assert.Equal(Math.PI * 25, circle.GetSquare());
    }

    [Fact]
    public void FindCircleArea_Radius_5_Equal_Pix25_CreateNewFigure()
    {
        var circle = new FigureBuilder(new Circle(5));

        Assert.Equal(Math.PI * 25, circle.GetSquare());
    }



    [Fact]
    public void FindCircleArea_Radius_10_Equal_Pix100_CreateConstruct()
    {
        var circle = new FigureBuilder(10);

        Assert.Equal(Math.PI * 100, circle.GetSquare());
    }

    [Fact]
    public void FindCircleArea_Radius_10_Equal_Pix100_CreateCircle()
    {
        var circle = FigureBuilder.CreateCircle(10);

        Assert.Equal(Math.PI * 100, circle.GetSquare());
    }

    [Fact]
    public void FindCircleArea_Radius_10_Equal_Pix100_CreateNewFigure()
    {
        var circle = new FigureBuilder(new Circle(10));

        Assert.Equal(Math.PI * 100, circle.GetSquare());
    }


}