using System;

namespace Chap12Prog10
{
    abstract class TwoD: Shape
    {
        public int Dimension1 { get; set; }
        public int Dimension2 { get; set; }



        public TwoD(int x, int y, int d1, int d2) :
            base(x, y)
        {
            Dimension1 = d1;
            Dimension2 = d2;
        }

        public abstract double Area
        {
            get;
        }
    }
}
