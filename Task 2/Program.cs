using System;
class Circle
{
    public const double PI = 3.14;
    public double Radius { get; set; }
    
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public double Area()
    {
        return PI * Radius * Radius;
    }
    
    public double Perimeter()
    {
        return 2 * PI * Radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        
         circle.PI = 3.14159;

        Console.WriteLine("Area: " + circle.Area());
        Console.WriteLine("Perimeter: " + circle.Perimeter());
    }
}