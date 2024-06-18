using ShapeLibrary.Classes;

namespace ShapeCalculateAreaTest;

public class UnitTestForCircle
{
    [Fact]
    public void Constructor_RadiusIsZero_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }

    [Fact]
    public void Constructor_RadiusNegative_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }

    [Fact]
    public void CalculateArea_RadiusIsPositive_ReturnsCorrectArea()
    {
        double radius = 5;
        Circle circle = new Circle(radius);
        
        double expectedArea = Math.PI * Math.Pow(radius, 2);
        double actualArea = ShapeAreaCalculator.CalculateArea(circle);
        
        Assert.Equal(expectedArea, actualArea, 10);
    }
}