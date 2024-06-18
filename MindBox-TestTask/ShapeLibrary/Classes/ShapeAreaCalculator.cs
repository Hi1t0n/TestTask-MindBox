using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Classes;

public static class ShapeAreaCalculator
{
    /// <summary>
    /// Метод для подсчета площади у любой фигуры класс которой реализует IShape
    /// </summary>
    /// <param name="shape">Инфтерфейс фигур</param>
    /// <returns>Площадь фигуры</returns>
    public static double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}