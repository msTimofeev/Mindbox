using System;
using System.Linq;

namespace Mindbox
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        private Circle(double[] radius)
        {
            _radius = radius.First();
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        public double Aria()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
