using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Classes;

/// <summary>
/// Класс реализующий интерфейс IShape <see cref="IShape"/>
/// </summary>
public class Triangle : IShape
{
    public double SideA { get;}
    public double SideB { get;}
    public double SideC { get;}

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Длины сторон должны быть больше 0");
        }

        if (!IsValidTriangle(sideA, sideA, sideC))
        {
            throw new ArgumentException($"Треугольник со сторонами {sideA}, {sideB}, {sideC} - не может существовать"); 
        }
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    /// <inheritdoc/>
    public double CalculateArea()
    {
        double p = CalculatePerimeter() / 2; // Считаем полупериметер
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
    
    /// <summary>
    /// Периметр 
    /// </summary>
    /// <returns></returns>
    public double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }
    
    /// <summary>
    /// Проверка на прямоугольный треугольник
    /// </summary>
    /// <returns>true - является | false - не является</returns>
    public bool IsRightTriangle()
    {
        List<double> triangleSides = new() { SideA, SideB, SideC };
        triangleSides.Sort();

        return (Math.Abs(Math.Pow(triangleSides[0], 2) + Math.Pow(triangleSides[1], 2) - Math.Pow(triangleSides[2], 2)) < 1e-10);
    }
    
    /// <summary>
    /// Метод проверяющий может ли существовать треугольник с заданными сторонами
    /// </summary>
    /// <param name="a">Сторона 1</param>
    /// <param name="b">Сторона 2</param>
    /// <param name="c">Сторона 3</param>
    /// <returns>True - если может | False - если не может</returns>
    public bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && b + c > a && c + a > b;
    }
}