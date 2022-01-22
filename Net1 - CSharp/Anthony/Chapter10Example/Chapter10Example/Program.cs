using System;

namespace Chapter10Example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle r1 = new Rectangle();
                Console.WriteLine(r1);

                Rectangle.color = "red";

                Rectangle r2 = new Rectangle(7.82, 12.99);
                Console.WriteLine(r2);

                r1.Length = 32;
                Console.WriteLine(r1);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\n {0}\n", ex.Message);
            }
            try
            {
                Rectangle r3 = new Rectangle();
                Console.WriteLine(r3);

                r3.Width = 99;
                Console.WriteLine(r3);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("\n {0}\n", ex.Message);
            }

            Rectangle r4 = new Rectangle { Length = 4, Width = 2 }; // Another way to code it, try not to use it.
            // var r5 = new {Length = 4, Width = 5} creates a class?

            Console.ReadKey();
        }
    }
}
