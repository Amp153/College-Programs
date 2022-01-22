using System;

namespace Chap12Prog10
{
    class Circle: TwoD, IComparable
    {
       // string n;
        private int radius;

        public int Radius {
            get 
            {
                return radius; 
            }
            set 
            {
                radius = value;
            }
        }

        public Circle(int x, int y, int r)
            : base( x, y, r, r) 
        {
            Radius = r;
        }

        public override string Name
        {
            get { return "Circle"; }
         //   set
         //   {
         //       n = value;
         //   }
        }

        public override double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public override string ToString()
        {
            return "Circle with coordinates" + base.ToString();
        }

        //for interface Icomparable
        public int CompareTo(Object otherC)
        {
           // if (Area > ((Circle)otherC).Area)
                if (Area > ((TwoD)otherC).Area)
                return 1;
           // else if (Area < ((Circle)otherC).Area)
                 else if (Area < ((TwoD)otherC).Area)
                return -1;
            else
                return 0;
        }

    }
}
