using System;


// Interface
// An interface is a completely "abstract class",
// which can only contain abstract methods and
// properties (with empty bodies).

interface IShape
{
    double GetArea();
}

interface IColor
{
    string GetColor();
}


// multiple inheritance
class Rectangle : IShape, IColor
{
    private double l;
    private double b;
    private string color;

    public Rectangle(double l, double b, string color)
    {
        this.l = l;
        this.b = b;
        this.color = color;
    }

    public double GetArea()
    {
        return l * b;
    }

    public string GetColor()
    {
        return color;
    }
}


namespace _14._Interface____Multiple_inheritance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface : ");

            // Multiple Inheritance
            Console.WriteLine("Multiple Inheritance : ");
            Rectangle rect = new Rectangle(7, 18, "Red");
            Console.WriteLine("Area of rectangle : " + rect.GetArea());
            Console.WriteLine("Color of rectangle : " + rect.GetColor());
        }
    }
}
