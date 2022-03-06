using System;

namespace Mindbox
{
    public class Triangle : IFigure
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        private Triangle(double[] args)
        {
            _sideA = args[0];
            _sideB = args[1];
            _sideC = args[2];
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        public double Aria()
        {
            if (isRightTriangle())
            {
                return _sideA * _sideB / 2;
            }
            
            var halfPerimeter = Perimeter() / 2;
            var area = Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));
            return area;
        }

        /// <summary>
        /// Вычисление периметр треугольника
        /// </summary>
        private double Perimeter()
        {
            return _sideA + _sideB + _sideC;
        }
        
        /// <summary>
        /// Проверка, что треугольник является прямоугольным
        /// </summary>
        private bool isRightTriangle()
        {
            return (Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2)).Equals(Math.Pow(_sideC, 2));
        }
    }
}
