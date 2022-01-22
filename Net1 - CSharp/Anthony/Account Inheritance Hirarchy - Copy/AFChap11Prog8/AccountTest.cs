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
                // ac1 = Account class testing
                Account ac1 = new Account(100);
                Console.WriteLine(ac1);
                ac1.Credit = 200;
                Console.WriteLine(ac1);

                //Testing the exception handling
               // ac1.Credit = -2000;
              //  Console.WriteLine(ac1);

                ac1.Debit = 100;
                Console.WriteLine(ac1);

                //ac2 = SavingsAccount class testing
                Console.WriteLine("SavingsAccount class testing");
                SavingsAccount ac2 = new SavingsAccount(10, .5m);
                Console.WriteLine(ac2);
                ac2.CalculateInterest();
                Console.WriteLine(ac2);
                Console.WriteLine("Test adding interest to SavingsAccount class\n" + ac2);
                ac2.Credit = ac2.CalculateInterest();
                Console.WriteLine(ac2);


                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\n {0}\n", ex.Message);
            }
        }
    }
}
