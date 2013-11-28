using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Customers could be individuals or companies.

public class Company : Customer
{
    public string VATnumber { get; set; }

    public Company(string name, string address, string vat)
        : base(name, address)
    {
        this.VATnumber = vat;
    }
}