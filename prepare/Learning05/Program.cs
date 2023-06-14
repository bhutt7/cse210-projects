using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("blue", 12);
        Rectangle rectangle = new Rectangle("red", 12, 10);
        Circle circle = new Circle("green", 4);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);  

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}