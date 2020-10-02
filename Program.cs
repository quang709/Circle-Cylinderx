using System;

namespace Circle_Cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine($"Radius is {c1.getRadius()}\nColor is {c1.getColor()}\nBase area is {c1.getArea()}");
            Console.WriteLine();
            Cylinder c2 = new Cylinder(5.0, 2.0);
            Console.WriteLine($"Radius is {c2.getRadius()}\nHeight is {c2.getHeight()}\nColor is {c2.getColor()}\nBase area is {c2.getArea()}\nVolume is {c2.getVolume()}");
        }
    }
}
