using System;
using System.ComponentModel;
using Calculations;

namespace MortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.FixedPricing money = new Calculator.FixedPricing();
            
            Console.WriteLine("""
            Welcome to a MORTAGE CALCULATOR
            
            please enter the homePrice:

            """);
            money.homePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Thank you, now enter the interest rate: ");
            Console.WriteLine();
            money.APR = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Thank you, now please enter the loan length, 15 or 30 years");
            Console.WriteLine();
            money.loanChoice = Console.ReadLine();
            if (money.loanChoice.Contains("15"))
            {
                money.loanPricing15(money.homePrice, money.APR, money.loanLength15);
            }
            else if (money.loanChoice.Contains("30"))
            {
                money.loanPricing30(money.homePrice, money.APR, money.loanLength30);
            }
            else
            {
                return;
            }
            

            
        }
    }
}
