//Anthony Fuller

using System;

namespace AF_Ch8_Prog17
{
    class Program
    {
        static void Main(string[] args)
        {
            //The chapter has a nearly identical app (only 1 dice) already written.

            Random randomNumbers = new Random();
            int[] frequency = new int[13];
            int frequency1;
            int frequency2;
            double total = 36000;


            for (int roll = 1; roll <= total; ++roll)
            {
                frequency1 = randomNumbers.Next(1, 7);
                frequency2 = randomNumbers.Next(1, 7);
                int sumFre = frequency1 + frequency2;
                ++frequency[sumFre];
            }

            Console.WriteLine("{0}{1,12}{2,13}", "Sum", "Frequency","Percentage");

            for (int face = 2; face < frequency.Length; ++face){
                Console.WriteLine("{0,4}{1,12}{2,13:p0}",face,frequency[face],total/(total-frequency[face])-1);}
        }
    }
}
