
namespace TestGetSquare;

public class CircleSquare
{

    [Fact]
    public void FindCircleArea_Radius_1_Equal_Pi()
    {
        var circle = new FigureBuilder(1);

        Assert.Equal(Math.PI, circle.GetSquare());
    }

    [Fact]
    public void FindCircleArea_Radius_10_Equal_Pix100()
    {
        var circle = new FigureBuilder(10);

        Assert.Equal(Math.PI * 100, circle.GetSquare());
    }

    [Fact]
    public void FindCircleArea_Radius_5_Equal_Pix25()
    {
        var circle = new FigureBuilder(new Circle(5));

        Assert.Equal(Math.PI * 25, circle.GetSquare());
    }
}