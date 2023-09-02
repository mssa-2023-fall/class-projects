
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Calculations
{
    public class Calculator
    {
        public class FixedPricing
        {
            public double homePrice;
            public double APR;
            public double loanAmount;
            public int loanLength15 = 15;
            public int loanLength30 = 30;
            public string loanChoice;
            public int year = 12;
            public double loanPricing15(double homePrice, double APR, int loanLength15)
            {
                //P * (r / n) * [(1 + r / n)^n(t)] / [(1 + r / n)^n(t) - 1]
                Console.WriteLine($"The homePrice is {homePrice}, divided by (APR ({APR}%) multiplied by 12 (payments per month) | This is for a {loanLength15}-year rate)");
                Console.WriteLine($"{homePrice * (APR / year) * (1 + APR / year)Math.Pow(year(loanLength15)) / (1 + APR / year) ,Math.Pow(year(loanLength15) - 1)}");
                return homePrice * (APR / loanLength15);
            }
            public double loanPricing30(double homePrice, double APR, int loanLength30)
            {
                //P * (r / n) * [(1 + r / n) ^ n(t)] / [(1 + r / n) ^ n(t) - 1]
                Console.WriteLine($"The homePrice is {homePrice}, divided by (APR ({APR}%) multiplied by 12 (payments per month) | This is for a {loanLength30}-year rate)");
                Console.WriteLine($"{homePrice * (APR / loanLength30)}");
                return homePrice * (APR / loanLength30);
            }
            
        }
       /* public class Length (int loanLength)
        {

        } */
    }
}


/*chatGPT response
Console.WriteLine("Mortgage Calculator");

Console.Write("Enter principal amount: ");
double principal = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter annual interest rate (%): ");
double interestRate = Convert.ToDouble(Console.ReadLine()) / 100.0;

Console.Write("Enter loan term (years): ");
int loanTermYears = Convert.ToInt32(Console.ReadLine());

int numberOfPayments = loanTermYears * 12;
double monthlyInterestRate = interestRate / 12;
double denominator = Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1;
double monthlyPayment = (principal * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments)) / denominator;

Console.WriteLine($"Monthly Payment: {monthlyPayment:C}");
*/