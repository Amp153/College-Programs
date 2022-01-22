//Anthony Fuller
//Chapter 10 Program 5

using System;

namespace Chapter10Prog5
{
    class SavingsAccount
    {
        //variables
        private decimal annualInterestRate = 0m;
        private decimal savingsBalance = 0m;

        public SavingsAccount()
            :this(0m,0m)
        {
        }

        public SavingsAccount(decimal interest,decimal startingBalance)
        {
            ModifyInterestRate = interest;
            if(startingBalance > 0m)
            CalculateMonthlyInterest = startingBalance;
        }

        public decimal AnnualInterestRate
        {
            get
            {
                return annualInterestRate;
            }

            set
            {
                if (value >= 0m)
                    annualInterestRate = value;
                else
                    throw new ArgumentOutOfRangeException("annualInterestRate", value,
                        "annualInterestRate can't be negative, 0 or greater please.");
            }
        }
        public decimal SavingsBalance
        {
            get
            {
                return savingsBalance;
            }

            set
            {
                if (value >= 0m)
                    savingsBalance = value;
                else
                    throw new ArgumentOutOfRangeException("savingsBalance", value,
                        "savingsBalance can't be negative, 0 or greater please.");
            }
        }
        public decimal CalculateMonthlyInterest
        {
            get
            {
                return SavingsBalance;
            }
            set
            {
                SavingsBalance += value + (value * AnnualInterestRate) / 12m;
            }
        }
        public decimal ModifyInterestRate
        {
             get
             {
                return AnnualInterestRate;
             }
            set
            {
                if (value >= 0m)
                    AnnualInterestRate = value;
                else
                   throw new ArgumentOutOfRangeException("annualInterestRate", value,
                        "annualInterestRate can't be negative, 0 or greater please.");
            }
        }

        // SavingsBalance seems to be the cause
      /*  public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3}}",
                "Balance", SavingsBalance, "Interest", AnnualInterestRate);
        }*/
    }
}
