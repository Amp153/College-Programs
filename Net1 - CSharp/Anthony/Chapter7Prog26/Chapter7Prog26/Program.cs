//Reverse the digits in integers
using System;

namespace Chapter7Prog26
{
    class Program
    {
        //eNum example that doesn't belong
        // enum Factors{
        // ONE = 1, TWO = 2, THREE = 3 }
        // include before main

        static void Main(string[] args)
        {
            // With eNum
            // Factors.ONE

            Program rd = new Program();

        }
            Program() {
            //int revNumber;
            int revNumber = 0;
            int num;

            Console.Write("Enter an integer (-1 to exit)");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != -1) 
            {
               // revNumber = ReverseDigits(num);
                //ReverseDigits(num, out revNumber);
                //rd.ReverseDigits(num, ref revNumber);
                ReverseDigits(num, ref revNumber);
                Console.WriteLine("{0} reversed is {1}", num, revNumber);
                
                Console.Write("Enter an integer (-1 to exit)");
                num = Convert.ToInt32(Console.ReadLine());
            }
            

            Console.ReadKey();
        }

       /* static int ReverseDigits(int origNumber)
        {
            int rN = 0;
            int rem;

            int number = Math.Abs(origNumber);

            while (number > 0)
            {
                rem = number % 10;
                number /= 10;
                rN = rN * 10 + rem;
            }
            if (origNumber >= 0)
                return rN;
            else
                return 0 - rN; */

           /*    static void ReverseDigits(int origNumber, out int rN)
        {
           // int rN = 0;
            rN = 0;
            int rem;

            int number = Math.Abs(origNumber);

            while (number > 0)
            {
                rem = number % 10;
                number /= 10;
                rN = rN * 10 + rem;
            }
            if (origNumber < 0)
                rN = 0 - rN;
        }*/
               void ReverseDigits(int origNumber, ref int rN)
               {
                   // int rN = 0;
                   rN = 0;
                   int rem;

                   int number = Math.Abs(origNumber);

                   while (number > 0)
                   {
                       rem = number % 10;
                       number /= 10;
                       rN = rN * 10 + rem;
                   }
                   if (origNumber < 0)
                       rN = 0 - rN;
               }

    }
}
