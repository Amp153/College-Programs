//Anthony Fuller
//Chapter 10 Program 5
//Test program

using System;

namespace Chapter10Prog5
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            try
            {
                SavingsAccount saver1 = new SavingsAccount();

                saver1.ModifyInterestRate = 4m;
                saver1.CalculateMonthlyInterest = 2000.00m;
                Console.WriteLine("Interest rate for saver1 is: " + saver1.AnnualInterestRate + "%");
                Console.WriteLine("Balance for saver1 is: " + saver1.SavingsBalance);

                SavingsAccount saver2 = new SavingsAccount(4m, 3000.00m);
                Console.WriteLine("Interest rate for saver2 is: " + saver2.AnnualInterestRate + "%");
                Console.WriteLine("Balance for saver2 is: " + saver2.SavingsBalance);

                //modifying the interest rates
                saver1.ModifyInterestRate = 5m;
                saver2.ModifyInterestRate = 5m;

                //displaying the new balance. Also I had to fix something which is why the numbers in the console look odd;
                Console.WriteLine("Balance for saver1 next month with a interest rate of {1}% is: {0}", saver1.CalculateMonthlyInterest, saver1.AnnualInterestRate);
                Console.WriteLine("Balance for saver2 next month with a interest rate of {1}% is: {0}", saver2.CalculateMonthlyInterest, saver2.AnnualInterestRate);
                

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\n {0}\n", ex.Message);
            }

                //This part was added because I don't know why there is a proplem with my override ToString
            catch (System.FormatException ex)
            {
                Console.WriteLine("\n {0}\n", ex.Message);
            }
        }
    }
}
