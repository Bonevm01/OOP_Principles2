using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Customers could be individuals or companies.

public class Individual : Customer
{
    public string EGN { get; set; }

    public Individual(string name, string address, string egn)
        : base(name, address)
    {
        this.EGN = egn;
    }
}
