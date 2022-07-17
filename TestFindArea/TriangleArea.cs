namespace FiguresArea.Tests;

public class TriangleArea
{

    [Fact]
    public void FindTriangeArea_5_4_3_Equal_6()
    {
        var triangle = new FigureBuilder(5, 4, 3);

        Assert.Equal(6, triangle.GetSquare());
    }

    [Fact]
    public void FindTriangeArea_5_12_13_Equal_30()
    {
        var triangle = new FigureBuilder(5, 12, 13);

        Assert.Equal(30, triangle.GetSquare());
    }

    [Fact]
    public void FindTriangeArea_65_72_97_Equal_30()
    {
        var triangle = new FigureBuilder(new Triangle (65, 72, 97));

        Assert.Equal(2340, triangle.GetSquare());
    }
}
