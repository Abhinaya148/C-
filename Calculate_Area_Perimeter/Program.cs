//problem-1 abstract class shape
using System;
using System.Collections.Generic;

// Abstract base class Shape
abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

// Circle subclass
class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

// Rectangle subclass
class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

// Triangle subclass
class Triangle : Shape
{
    public double Side1 { get; }
    public double Side2 { get; }
    public double Side3 { get; }

    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public override double CalculateArea()
    {
        double s = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
    }

    public override double CalculatePerimeter()
    {
        return Side1 + Side2 + Side3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(7.6),
            new Rectangle(2.62, 3.21),
            new Triangle(9.0, 8.41, 1.10)
        };

        double totalArea = 0.0;
        double totalPerimeter = 0.0;

        foreach (var shape in shapes)
        {
            totalArea += shape.CalculateArea();
            totalPerimeter += shape.CalculatePerimeter();
        }

        Console.WriteLine("Total Area: " + totalArea);
        Console.WriteLine("Total Perimeter: " + totalPerimeter);
    }
}