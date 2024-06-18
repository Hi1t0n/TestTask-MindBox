using ShapeLibrary.Classes;

namespace ShapeCalculateAreaTest;

public class UnitTestForTriangle
{
    [Fact]
    public void Constructor_SideIsZero_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(0, 3, 2));
    }

    [Fact]
    public void Constructor_SideNegative_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-1, 2, 3));
    }

    [Fact]
    public void Constructor_InvalidSides_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }

    [Fact]
    public void IsRightTriangle_ReturnsTrue()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        bool expectedResult = true;
        bool actualResult = triangle.IsRightTriangle();
        Assert.Equal(expectedResult, actualResult);
    }
    
    [Fact]
    public void CalculateArea_ValidSides_ReturnsCorrectArea()
    {
        double a = 3, b = 4, c = 5;
        Triangle triangle = new Triangle(a, b, c);
        double expectedArea = 6;

        double actualArea = ShapeAreaCalculator.CalculateArea(triangle);

        Assert.Equal(expectedArea, actualArea, 10);
    }
}