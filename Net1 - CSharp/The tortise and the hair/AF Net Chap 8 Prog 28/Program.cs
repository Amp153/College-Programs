using System;

namespace AF_Net_Chap_8_Prog_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int turtlePos = 1;
            int harePos = 1;
            //Tortoise Fast plod = 50%(3r), Slip = 20%(6l), and Slow plod = 30%(1r)
            //Hare Sleep = 20%(none), Big hop = 20%(9r), Big slip = 10%(12l), Small hop = 30%(1r), and small slip = 20%(2l)

            Console.WriteLine("ON YOUR MARK, GET SET");
            Console.WriteLine("BANG!!!!");
            Console.WriteLine("AND THEY'RE OFF!!!!!");

            Console.WriteLine("Tortoise {0}", turtlePos);
            Console.WriteLine("Hare: {0}", harePos);

            int move = randomNum.Next(1,11);
            

        }
        public static Random randomNum = new Random();
    }
}
