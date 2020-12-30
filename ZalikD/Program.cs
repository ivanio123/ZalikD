using System;

namespace ZalikD
{
    class Program
    {
        static void Main(string[] args)
        {
           Figure triangle = new Triangle(new Point(2,3),new Point(-3,1),new Point(-4,-2) );
           Console.WriteLine(triangle.Perimeter());
           Console.WriteLine(triangle.Square());
           Figure circle = new Circle(5);
           Console.WriteLine(circle.Perimeter());
           Console.WriteLine(circle.Square());
        }
    }
}