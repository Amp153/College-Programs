using System;


namespace ExceptionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SomeMethod1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception handled in Main");
            }

            Console.ReadKey();
        }

        private static void SomeMethod1() 
        {
            try
            {
                SomeMethod2();
            }
            catch (Exceptional e)
            {
                Console.WriteLine("Exception handled in SomeMethod1");
                e.
            }
        }

        private static void SomeMethod2()
        {
            //throw new Exception();
            //Exception up = new Exception();
            Exceptional up = new Exceptional();
            throw up;
        }
    }

    //define a new exception-type of class
    class Exceptional : Exception
    {
        public Exceptional()
            : base("Made up problem")
        {
        }

    }

}
