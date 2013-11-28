// Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Shape(double width, double height)
    {
        this.Height = height;
        this.Width = width;
    }
    
    public abstract double CalculateSurface();
}