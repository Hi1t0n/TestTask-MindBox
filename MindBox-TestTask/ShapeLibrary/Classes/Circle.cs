using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Classes;

/// <summary>
/// Класс реализующий интерфейс IShape <see cref="IShape"/>
/// </summary>
public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус не может быть меньше или равен 0");
        }
        Radius = radius;
    }

    /// <inheritdoc/>
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}