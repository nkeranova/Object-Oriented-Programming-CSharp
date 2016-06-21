/// <summary>
///Problem 2. Bank accounts
///
///A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
///All accounts have customer, balance and interest rate (monthly based).
///Deposit accounts are allowed to deposit and with draw money.
///Loan and mortgage accounts can only deposit money.
///All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
///Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
///Deposit accounts have no interest if their balance is positive and less than 1000.
///Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
///Your task is to write a program to model the bank system by classes and interfaces.
///You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
/// </summary>
/// 
namespace BankAccounts
{
    using System;

    class BankMain
    {
        static void Main()
        {
            Customer kircho = new Individual("a001", "Kiro", "8503122535", new DateTime(1990, 10, 25), Gender.Male);

            Customer firmata = new Company("a002", "p2p", "503122535");

            Console.WriteLine(firmata is Individual);
            Console.WriteLine(kircho is Individual);

            BankAccount mortgageAccTest = new MortgageAccount(200.2m, 0.6m, kircho);
            BankAccount mortgageAccTest1 = new MortgageAccount(200.2m, 0.6m, firmata);

            Console.WriteLine(mortgageAccTest.CalculateInterest(15));
            Console.WriteLine(mortgageAccTest1.CalculateInterest(15));

            BankAccount loanAccTest = new LoanAccount(200.2m, 0.6m, kircho);
            BankAccount loanAccTest1 = new LoanAccount(200.2m, 0.6m, firmata);

            Console.WriteLine(loanAccTest.CalculateInterest(11));
            Console.WriteLine(loanAccTest1.CalculateInterest(11));

            BankAccount depositAccTest = new DepositAccount(3200.2m, 0.6m, kircho);
            BankAccount depositAccTest1 = new DepositAccount(1200.2m, 0.6m, firmata);

            Console.WriteLine(depositAccTest.CalculateInterest(11));
            Console.WriteLine(depositAccTest1.CalculateInterest(11));

            depositAccTest.Deposit(200);
            Console.WriteLine(depositAccTest.Balance);
            var depositAcc = depositAccTest as DepositAccount;
            depositAcc.Withdraw(300);
            Console.WriteLine(depositAcc.Balance);
        }
    }
}