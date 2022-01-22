//Anthony Fuller
using System;


namespace AF_NET_Chap_7_Prog_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int again;

            do
            {
                
                int num;

                num = randomNumbers.Next(1, 1001);

                int guess;

                do
                {
                    Console.WriteLine("Guess the number between 1 - 1000: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > num)
                        Console.WriteLine("Too high. Try again.");
                    if (guess < num)
                        Console.WriteLine("Too low. Try again.");
                    if (guess == num)
                        Console.WriteLine("Congratulations. You guessed the number!");

                } while (num != guess);

                Console.WriteLine("Would you like to play again? \n (Enter -1 if you would like to play another round)");
                again = Convert.ToInt32(Console.ReadLine());

            } while (again == -1);
        }
        public static Random randomNumbers = new Random();
    }
}
