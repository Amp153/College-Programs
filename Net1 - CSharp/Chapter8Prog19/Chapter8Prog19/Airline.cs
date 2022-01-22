using System;

namespace Chapter8Prog19
{
    class Airline
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            //2-d array         rectangular
            int[,] array1 = new int[3,4];
            for(int r = 0; r < array1.GetLength(0); r++)
                for(int c = 0; c < array1.GetLength(1); c++)
                    array1[r,c] = ran.Next();

            foreach(int x in array1)
                Console.WriteLine("Value is {0}", x);

            //2-d       jagged
            int[][] y;
            y = new int[3][];
            y[0] = new int[4];
            y[1] = new int[2];
            y[2] = new int[2];

            y[1][1] = 54;
        }
        
            /*
            bool[] seats = new bool[10];
            int selection;
            int seat;
            char check;
            int repeat = 0;
            do{

            Console.WriteLine("Please type 1 for First Class and " +
                "Please type 2 for Economy");
            selection = Convert.ToInt32(Console.ReadLine());

            //validation
            while (selection < 1 || selection > 2)
            {
                Console.WriteLine("Invalid entry, re-enter a 1 or a 2");
                selection = Convert.ToInt32(Console.ReadLine());
            }

            if (selection == 1)
            {
                seat = SeatCheck(0, 4, seats);
                if (seat == -1) 
                {
                    Console.WriteLine("Sorry first class is full. Check economy? If so enter Y");
                    check = Console.ReadKey().KeyChar;
                    if (check == 'Y' || check == 'y')
                    { 
                        seat = SeatCheck(5, 9, seats);
                        if (seat == -1)
                        {
                            Console.WriteLine("The plan is full, next flight leaves in 3 hours.");
                            repeat = -1;
                        }
                        else
                        {
                            Console.WriteLine("You have been assigned to seat number: {0}", seat);
                        }
                    }
                    else
                    {
                        Console.WriteLine("The plan is full, next flight leaves in 3 hours.");
                        repeat = -1;
                    }

                }
                else
                {
                    Console.WriteLine("You have been assigned to seat number: {0}", seat);
                }
            }
            if (repeat != -1)
            {
                Console.WriteLine("Select another seat? If so, enter 1");
                repeat = Convert.ToInt32(Console.ReadLine());
            }
            }while(repeat==1);
            
            }
        

        //method to check for seat availability
        public static int SeatCheck(int start, int end, bool[] seats)
        {
            
            bool found = false;
            int x;
            for (x = start; x <= end && !found; x++) 
            {
                if (!seats[x])
                {
                    seats[x] = true;
                    found = true;
                }
            }
            if (found) 
                return x; 
             else
                return -1;
        }*/
    }
}
