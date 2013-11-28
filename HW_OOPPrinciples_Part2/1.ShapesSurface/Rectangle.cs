//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure
//(height*width for rectangle and height*width/2 for triangle). 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Rectangle : Shape
{
    public Rectangle(double h, double w)
        : base(h, w)
    {
    }

    public override double CalculateSurface()
    {
        return this.Width * this.Height; ;
    }

    public override string ToString()
    {
        return string.Format("I am a {0}. My width is {1} and my height is {2}", this.GetType().Name, this.Width, this.Height);
    }

}
