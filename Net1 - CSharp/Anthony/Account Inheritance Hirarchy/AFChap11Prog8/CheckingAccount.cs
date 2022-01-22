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

        public override void Credit(decimal value)
        {
            base.Credit(value);
            Balance -= feeAmount;
            // set
            // {
            //      value = value - feeAmount;
            //     if (value > 0)
            //         Balance += value;
            //     else
            //         throw new ArgumentOutOfRangeException("Balance", value,
            //                "Balance can't be negative, 0 or greater please.");
            // }
        }
        // public virtual Decimal Debit
       public override bool Debit(decimal value)
        {
          if (base.Debit(value))
         //   set
            {
               Balance -= feeAmount;
               return true;
                //value = value + feeAmount;
               // if (value < Balance)
               // {
               //     Balance -= value;
                }
                else {
                   // throw new ArgumentOutOfRangeException("Limit Exceeded", value,
                   //         "Debit amount exceeded account balance.");
                    return false;
               }
            }
       public override string ToString()
       {
           return string.Format("Balance is: {0:C} The fee amount is : {1}",
               Balance, feeAmount);
       }
        }
}
