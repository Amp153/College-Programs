//Anthony Fuller
using System;

namespace AFChap11Prog8
{
    class CheckingAccount: Account
    {
        private decimal feeAmount;

        public CheckingAccount(decimal initialBalance, decimal feeCharged):
            base(initialBalance)
        {
            feeAmount = feeCharged;
        }


        public virtual Decimal Credit 
        {
            set
            {
                value = value - feeAmount;
                if (value > 0)
                    Balance += value;
                else
                    throw new ArgumentOutOfRangeException("Balance", value,
                            "Balance can't be negative, 0 or greater please.");
            }
        }

        // It doesn't seem like a boolean is required
        public virtual Decimal Debit
        {
            set
            {
                value = value + feeAmount;
                if (value < Balance)
                {
                    Balance -= value;
                }
                else
                    throw new ArgumentOutOfRangeException("Limit Exceeded", value,
                            "Debit amount exceeded account balance.");
            }
        }
    }
}
