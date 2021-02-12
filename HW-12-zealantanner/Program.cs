using System;

abstract class Shape
{
    public abstract int GetArea();
    public abstract int GetPerimeter();
}

class Rectangle : Shape
{
    int height;
    int width;

    public Rectangle(int h, int w) => (height, width) = (h, w);

    public override int GetArea() => height * width;
    public override int GetPerimeter() => (height + width) * 2;
}

class Square : Shape
{
    int side;

    public Square(int n) => side = n;

    public override int GetArea() => side * side;
    public override int GetPerimeter() => side * 4;
}

class Program
{
    static void Main()
    {
        var sq = new Square(12);
        Console.WriteLine($"Area of the square = {sq.GetArea()}");
        Console.WriteLine($"Perimeter of the square = {sq.GetPerimeter()}");

        var re = new Rectangle(11,12);
        Console.WriteLine($"Area of the rectangle = {re.GetArea()}");
        Console.WriteLine($"Perimeter of the rectangle = {re.GetPerimeter()}");

    }
}
