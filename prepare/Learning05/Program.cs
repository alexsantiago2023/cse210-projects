using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();

        _shapes.Add(new Square("red", 5));
        _shapes.Add(new Rectangle("orange", 3, 12));
        _shapes.Add(new Circle("blue", 4));

        foreach (Shape s in _shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}