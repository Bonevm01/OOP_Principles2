// Write a program that tests the behavior of  the CalculateSurface() method for different shapes 
// (Circle, Rectangle, Triangle) stored in an array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Test
{
    static void Main(string[] args)
    {
        Shape[] figures = new Shape[]
        {
            new Triangle(2.3, 3.1),
            new Rectangle(2.3, 3.1),
            new Circle(1),
            new Circle(2.5),
            new Triangle(1,5)
        };

        foreach (Shape item in figures)
        {
            Console.WriteLine(item);
            Console.WriteLine("Surface -> {0}", item.CalculateSurface());
        }
    }
}
