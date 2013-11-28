//Define class Circle and suitable constructor so that at initialization height 
//must be kept equal to width and implement the CalculateSurface() method. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Circle : Shape
{
    public Circle(double radius)
        : base(radius, 0)
    {
        this.Height = this.Width;
    }

    public override double CalculateSurface()
    {
        return Math.PI*this.Width*this.Height;
    }

    public override string ToString()
    {
        return string.Format("I am a {0}. My radius is {1}.", this.GetType().Name, this.Width);
    }

}
