using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Deposit accounts are allowed to deposit and with draw money
public class Deposit : Account, IWithdraw
{

    public Deposit(Customer cust, double balance, double interest)
        : base(cust, balance, interest)
    {
    }

    public Deposit(Customer cust, double interest)
        : base(cust, 0, interest)
    {
    }

    public void WithdrawMoney(double ammount)
    {
        if (this.Balance < ammount)
        {
            throw new ArgumentOutOfRangeException("You can't withdraw more money than you balance.");
        }
        this.Balance -= ammount;
    }

    // Deposit accounts have no interest if their balance is positive and less than 1000.
    public override void CalculateInterest(byte months)
    {
        double interest = 0;
        if (this.Balance > 1000)
        {
            interest = this.Balance * months * this.InterestRate / 100;
        }

        this.Balance += interest;
    }
}
