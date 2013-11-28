using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Loan and mortgage accounts can only deposit money.

public class Loan : Account
{
    public Loan(Customer cust, double balance, double interest)
        : base(cust, balance, interest)
    {
    }

    // Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months
    // if are held by a company.

    public override void CalculateInterest(byte months)
    {
        double interest = 0;
        if (this.AccountHolder is Individual && months > 3)
        {
            interest = this.Balance * (months - 3) * this.InterestRate / 100;
        }

        if (this.AccountHolder is Company && months > 2)
        {
            interest = this.Balance * (months - 2) * this.InterestRate / 100;
        }

        this.Balance += interest;
    }

    //When you deposit money in Loan account you pay your debt
    public override void DepositMoney(double ammount)
    {
        if (ammount > this.Balance)
        {
            throw new ArgumentOutOfRangeException("You are not expected to deposit more than loan's ammount.");
        }
        this.Balance -= ammount;
    }

}
