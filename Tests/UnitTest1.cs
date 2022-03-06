using System;
using Mindbox;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void FigureFactory_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => FigureFactory.CreateFigure("", 6));
        }

        [Test]
        public void FigureFactory_InvalidCastException()
        {
            Assert.Throws<InvalidCastException>(() => FigureFactory.CreateFigure("Mindbox.FigureFactory", 6));
        }

        [Test]
        public void Triangle_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => FigureFactory.CreateFigure<Triangle>());
            Assert.Throws<ArgumentException>(() => FigureFactory.CreateFigure<Triangle>(-6));
            Assert.Throws<ArgumentException>(() => FigureFactory.CreateFigure<Triangle>(1, 1, 1, 1));
        }

        [Test]
        public void Circle_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => FigureFactory.CreateFigure<Circle>());
            Assert.Throws<ArgumentException>(() => FigureFactory.CreateFigure<Circle>(-6));
            Assert.Throws<ArgumentException>(() => FigureFactory.CreateFigure<Circle>(1, 1, 1, 1));
        }

        [Test]
        public void Circle_Aria()
        {
            var circle = FigureFactory.CreateFigure<Circle>(6);
            var area = circle.Aria();

            Assert.AreEqual(Math.PI * Math.Pow(6, 2), area);
        }

        [Test]
        public void Triangle_Aria()
        {
            var triangle = FigureFactory.CreateFigure<Triangle>(8, 5, 5);
            var area = triangle.Aria();

            Assert.AreEqual(12, area);
        }
    }
}