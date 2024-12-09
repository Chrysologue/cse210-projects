using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Blue", 5.23);
        Rectangle rectangle = new Rectangle("Red", 6.12, 4.88);
        Circle circle = new Circle("Green", 3.89);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} shape has area of {shape.GetArea()}");
        }
    }
}