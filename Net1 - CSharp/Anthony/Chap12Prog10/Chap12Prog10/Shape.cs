using System;

namespace Chap12Prog10
{
    abstract class Shape
    {
        //properties - auto-implemented
        public int X { get; set; }
        /* int x; //x = Convert.ToInt32(s);
         * string s = "123";
         * do
         * {
         * result = Int32.TryParse(s,out x);
         * } while (!result);
         * 
         * private x;

        public int X
        {
            get
            {
                return X;
            }
            set
            {
                if (value < -100 || value > 100)
                Console.WriteLine("That's bad");
         * throw new ArgumentOutOfRangeException(); 
            }
        }*/
        public int Y { get; set; }

        //constructor
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }

        //add something that's abstract
        public abstract string Name
        {
            get;
        }
    }
}
