// Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
// by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class InvalidRangeExceptionTest
{
    static void Main()
    {
        Console.Write("Enter a number bethween 1 and 100: ");
        int input = int.Parse(Console.ReadLine());
        try
        {
            if (input > 0 && input < 101)
            {
                Console.WriteLine("Correct input.");
            }
            else
            {
                throw new InvalidRangeException<int>(1, 100);
            }
        }
        catch (InvalidRangeException<int> ex)
        {

            Console.WriteLine(ex.Message);
            Console.WriteLine("The above message has just been cathed as exeption message.");
        }

        //DateTime expetion
        DateTime min = new DateTime(1980, 1, 1);
        DateTime max = new DateTime(2013, 12, 31);
        Console.Write("Enter a date in format \"d/m/yyyy\" from {0: d/M/yyy} to {1:d/M/yyy}: ", min, max);
        DateTime input2 = DateTime.Parse(Console.ReadLine());

        try
        {
            if (input2.CompareTo((min)) != -1 && input2.CompareTo(max) == -1)
            {
                Console.WriteLine("Correct input.");
            }
            else
            {
                throw new InvalidRangeException<DateTime>(min, max);
            }
        }
        catch (InvalidRangeException<DateTime> ex)
        {

            Console.WriteLine(ex.Message);
            Console.WriteLine("The above message has just been cathed as exeption message.");
        }

    }
}
