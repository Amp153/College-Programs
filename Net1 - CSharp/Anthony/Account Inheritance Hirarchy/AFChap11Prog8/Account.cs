﻿//Anthony Fuller
using System;

namespace AFChap11Prog8
{
    abstract class Account
    {
       //private instance variable
            private decimal balance;

        // Constructors
            public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }
            public Account()
            {
                balance = 0;
            }
        public virtual void Credit(decimal value)
            {
              //  set
             //   {
                    if (value > 0)
                        Balance += value;
                    else
                        throw new ArgumentOutOfRangeException("Balance", value,
                                "Balance can't be negative, 0 or greater please.");
              //  }
            }

          //  public Decimal Debit 
        public virtual bool Debit(decimal value)
        {
            // set
            // {
            if (value < Balance)
            {
                Balance -= value;
                return true;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Limit Exceeded", value,
                        "Debit amount exceeded account balance.");
            }
        }

            public Decimal Balance
        {
            get 
            {
                return balance;
            }
            set
            {
                if (value > 0)
                    balance = value;
                else
                    throw new ArgumentOutOfRangeException("Balance", value,
                            "Balance can't be negative, 0 or greater please.");
            }
        }
        public override string ToString()
        {
            return string.Format("Balance is: \n{0:C}",
                balance);
        }
    }
    
}
