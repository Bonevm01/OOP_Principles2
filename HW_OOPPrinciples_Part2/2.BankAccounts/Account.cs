//All accounts have customer, balance and interest rate (monthly based). 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Account
{
    private double balance;
    public double InterestRate { get; set; }
    public Customer AccountHolder { get; set; }

    public double Balance
    {
        get
        {
            return this.balance;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The balance can't be negative.");
            }
            this.balance = value;
        }
    }
    public Account(Customer cust, double balance, double interest)
    {
        this.AccountHolder = cust;
        this.Balance = balance;
        this.InterestRate = interest;
    }

    public Account(Customer cust, double interest)
        : this(cust, 0, interest)
    {
    }

    //All kind of accounts allow deposit - that's why this method is part of the base class
    public virtual void DepositMoney(double ammount)
    {
        this.Balance += ammount;
    }

    //All accounts can calculate their interest amount for a given period (in months). 
    //In the common case its is calculated as follows: number_of_months * interest_rate.
    
    public virtual void CalculateInterest(byte months)
    {
        this.Balance += this.Balance * months * this.InterestRate / 100;
    }
    
}
