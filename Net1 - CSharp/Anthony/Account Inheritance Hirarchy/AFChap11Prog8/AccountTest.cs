//Anthony Fuller
using System;

namespace AFChap11Prog8
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            try
            {
                // I was confused trying to follow the Account hierarchy.
                // I was also having problems trying to access the SavingsAccount CalculateInterest method because
                // my array consists of Account objects and not SavingsAccount objects
              

                
                Account[] acc = new Account[4];
                acc[0] = new SavingsAccount(200, .02m);
                acc[1] = new CheckingAccount(700, .02m);
                acc[2] = new SavingsAccount(100, .02m);
                acc[3] = new CheckingAccount(300, .02m);
                foreach (Account a in acc)
                    Console.WriteLine(a);
                acc[0].Credit(100);
                Console.WriteLine("100 credit applied to account 1 {0}",acc[0].Balance);
                acc[0].Debit(20);
                Console.Write("20 debit applied to account 1 {0}",acc[0].Balance);
                
                //acc[0].CalculateInterest();

                

                
              
                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\n {0}\n", ex.Message);
            }
        }
    }
}
