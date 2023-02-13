using System;
using Mindbox;
using NUnit.Framework;

namespace Tests;

public class Tests
{
    [Test]
    public void Triangle_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-8, -5, -5));
    }

    [Test]
    public void Circle_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-6));
    }

    [Test]
    public void Circle_Area()
    {
        IFigure circle = new Circle(6);

        Assert.AreEqual(Math.PI * Math.Pow(6, 2), circle.Area);
    }

    [Test]
    public void Triangle_Area()
    {
        IFigure triangle = new Triangle(8, 5, 5);

        Assert.AreEqual(12, triangle.Area);
    }
}