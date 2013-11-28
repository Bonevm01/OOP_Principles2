using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BankAccountsTest
{
    static void Main()
    {
        // Innstance of an individual and a Company customer
        Customer cust1 = new Individual("Misho", "Sofia", "541010");
        Customer cust2 = new Company("Albireo", "Plovdiv", "BG1211121121");
        
        // Deposit account-Individual customer
        Deposit account01 = new Deposit(cust1, 0.5);
        Console.WriteLine("Open new deposit for Individual. Starting ammount ->{0}", account01.Balance);
        account01.DepositMoney(1500);
        Console.WriteLine("Deposit 1500. Ammount ->{0}", account01.Balance);
        account01.WithdrawMoney(400);
        Console.WriteLine("Withdraw 400. Ammount ->{0}", account01.Balance);

        account01.CalculateInterest(5);
        Console.WriteLine("Calculate interest of {1}% for 5 months. Ammount ->{0}", account01.Balance, account01.InterestRate);
        account01.WithdrawMoney(600);
        Console.WriteLine("Withdraw 600. Ammount ->{0}", account01.Balance);
        account01.CalculateInterest(3);

        // 0% interest when balance is below 1000
        Console.WriteLine("Calculate interest of {1}% for 3 months. Ammount ->{0}", account01.Balance, account01.InterestRate);
        Console.WriteLine();

        //Loan account - Company
        Loan account02 = new Loan(cust2, 11000, 1);
        Console.WriteLine("Open new loan for a company. Ammount -> {0}", account02.Balance);
        account02.DepositMoney(3000);
        Console.WriteLine("Deposit 3000. Ammount -> {0}", account02.Balance);
        account02.CalculateInterest(2);
        // 0% interest or the first 2 months 
        Console.WriteLine("Calculate interest of {1}% for 2 months. Ammount ->{0}", account02.Balance, account02.InterestRate);
        account02.CalculateInterest(5);
        Console.WriteLine("Calculate interest of {1}% for 5 months. Ammount ->{0}", account02.Balance, account02.InterestRate);
        Console.WriteLine();

        //Loan Account - Individual
        Loan account03 = new Loan(cust1, 1000, 1.2);
        Console.WriteLine("Open new loan for an individual. Ammount -> {0}", account03.Balance);
        account03.DepositMoney(100);
        Console.WriteLine("Deposit 100. Ammount -> {0}", account03.Balance);
        // 0% interest or the first 3 months 
        account03.CalculateInterest(3);
        Console.WriteLine("Calculate interest of {1}% for 3 months. Ammount ->{0}", account03.Balance, account03.InterestRate);
        account03.CalculateInterest(5);
        Console.WriteLine("Calculate interest of {1}% for 5 months. Ammount ->{0}", account03.Balance, account03.InterestRate);
        Console.WriteLine();

        //Mortgage account - Individual
        Mortgage account04 = new Mortgage(cust1, 50000, 0.6);
        Console.WriteLine("Open new mortgage for an individual. Ammount -> {0}", account04.Balance);
        // 0% interest or the first 6 months 
        account04.CalculateInterest(6);
        Console.WriteLine("Calculate interest of {1}% for 6 months. Ammount ->{0}", account04.Balance, account04.InterestRate);
        account04.CalculateInterest(7);
        Console.WriteLine("Calculate interest of {1}% for 7 months. Ammount ->{0}", account04.Balance, account04.InterestRate);
        account04.DepositMoney(1500);
        Console.WriteLine("Deposit 1500. Ammount -> {0}", account04.Balance);
        Console.WriteLine();

        // Mortgage account - Company
        Mortgage account05 = new Mortgage(cust2, 500000, 0.4);
        Console.WriteLine("Open new mortgage for a company. Ammount -> {0}", account05.Balance);
        account05.CalculateInterest(10);
        Console.WriteLine("Calculate interest of {1}% for 10 months. Ammount ->{0}", account05.Balance, account05.InterestRate);
        account05.CalculateInterest(15);
        Console.WriteLine("Calculate interest of {1}% for 15 months. Ammount ->{0}", account05.Balance, account05.InterestRate);
        account05.DepositMoney(5000);
        Console.WriteLine("Deposit 5000. Ammount -> {0}", account05.Balance);
    }
}
