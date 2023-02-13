using System;

namespace Mindbox;

public class Triangle : IFigure
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;

        Validate();
    }

    /// <summary>
    /// Площадь фигуры
    /// </summary>
    public double Area
    {
        get
        {
            if (IsRightTriangle())
            {
                return _sideA * _sideB / 2;
            }

            var halfPerimeter = Perimeter() / 2;

            var area = Math.Sqrt(halfPerimeter *
                                 (halfPerimeter - _sideA) *
                                 (halfPerimeter - _sideB) *
                                 (halfPerimeter - _sideC));

            return area;
        }
    }

    /// <summary>
    /// Вычисление периметр треугольника
    /// </summary>
    private double Perimeter() => _sideA + _sideB + _sideC;

    /// <summary>
    /// Проверка, что треугольник является прямоугольным
    /// </summary>
    private bool IsRightTriangle() => (Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2)).Equals(Math.Pow(_sideC, 2));

    /// <summary>
    /// Валидация входных параметров
    /// </summary>
    private void Validate()
    {
        if (_sideA < 0 || _sideB < 0 || _sideC < 0)
        {
            throw new ArgumentException("Одна из сторон отрицательная");
        }
    }
}