using System;

class Program
{
    static void Main(string[] args)
    {
        // Square test = new Square("red", 5);
        // Console.WriteLine(test.GetColor());
        // Console.WriteLine(test.GetArea());
        // Rectangle test2 = new Rectangle("blue",5,2);
        // Console.WriteLine(test2.GetColor());
        // Console.WriteLine(test2.GetArea());
        // Circle test3 = new Circle("green",2);
        // Console.WriteLine(test3.GetColor());
        // Console.WriteLine(test3.GetArea());
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("black", 4));
        shapes.Add(new Circle("yellow", 4));
        shapes.Add(new Rectangle("purple", 5, 10));
        foreach(Shape shape in shapes){
            Console.WriteLine(shape.GetColor() + ", " + shape.GetArea());
        }
    }
}