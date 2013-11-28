using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Loan and mortgage accounts can only deposit money.

public class Mortgage : Account
{
    public Mortgage(Customer cust, double balance, double interest)
        : base(cust, balance, interest)
    {
    }

    //Mortgage accounts have ½ interest for the first 12 months for companies 
    // and no interest for the first 6 months for individuals.
    public override void CalculateInterest(byte months)
    {
        double interest = 0;
        if (this.AccountHolder is Individual && months > 6)
        {
            interest = this.Balance*(months - 6) * this.InterestRate / 100;
        }

        if (this.AccountHolder is Company)
        {
            if (months < 13)
            {
                interest = this.Balance * months * this.InterestRate / 200; // half interest for the first 12 months
            }
            else
            {
                interest = this.Balance * ((months - 12) * this.InterestRate / 100 + 12 * this.InterestRate / 200);
            }

        }

        this.Balance += interest;
    }

    //When you deposit money in Mortgage account you pay your debt
    public override void DepositMoney(double ammount)
    {
        if (ammount > this.Balance)
        {
            throw new ArgumentOutOfRangeException("You are not expected to deposit more than mortgage's ammount.");
        }
        this.Balance -= ammount;
    }
}
