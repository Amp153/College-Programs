//Anthony Fuller
using System;

namespace AFChap11Prog8
{
    class SavingsAccount: Account
    {
        private decimal rate;

        public SavingsAccount(decimal initialBalance, decimal interestRate):
            base(initialBalance)
        {
            rate = interestRate;
        }

        public Decimal Rate
        {
            get
            {
                return rate;
            }
            set
            {
                if (value > 0)
                    rate = value;
                else
                    throw new ArgumentOutOfRangeException("Interest rate", value,
                            "Interest rate can't be negative, 0 or greater please.");
            }
        }

        public Decimal CalculateInterest()
        {
            return Balance * rate;
        }
        public override string ToString()
        {
            return string.Format("Balance is: \n{0:C}\nInterest rate is : \n{1}",
                Balance, Rate);
        }
    }
}
