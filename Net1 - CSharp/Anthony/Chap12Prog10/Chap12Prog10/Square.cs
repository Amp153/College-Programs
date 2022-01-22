using System;

namespace Chap12Prog10
{
    class Square: TwoD
    {
        public Square(int x, int y, int l, int w)
            : base(x, y, l, w) 
        {
        }

        public override double Area
        {
            get 
            {
                return Dimension1 * Dimension2;
            }
        }

        public override string Name
        {
            get 
            {
                return "Square";
            }
        }
    }
}
