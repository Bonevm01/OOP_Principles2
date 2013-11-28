// Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
// It should hold error message and a range definition [start … end].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InvalidRangeException<T> : ApplicationException
{
    public T Min { get; set; }
    public T Max { get; set; }

    public InvalidRangeException(T minimum, T maximum)
        : base()
    {
        this.Max = maximum;
        this.Min = minimum;
    }
    
    public override string Message
    {
        get
        {
            return string.Format("Your input was out of the range {0}-{1}", this.Min, this.Max);
        }

    }

}