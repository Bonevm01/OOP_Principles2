using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Base abstract class for customers
public abstract class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }

    public Customer(string name, string address)
    {
        this.Address = address;
        this.Name = name;
    }
}
