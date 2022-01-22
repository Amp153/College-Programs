
using System;
namespace Chapter11
{
    //class Trap extends Quad //only in java
    class Trap: Quad
    {
        public Trap(double x1, double y1, double x2, double y2,
            double x3, double y3, double x4, double y4): 
            base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
            //super //java
            //cop out to figure out if the coordinates are ok to define a trapezoid
        }

        //compute height

        //compute sum of 2 sides


        //compute area
        public virtual double Area() //requires virtual only in c#
        {
            //sum of two sides/2 * height
            double sum;

            if (p1.Y == p2.Y)
                sum = Math.Abs(p1.X - p2.X) + Math.Abs(p3.X - p4.X);
            else
                sum = Math.Abs(p2.X - p3.X) + Math.Abs(p4.X - p1.X);

            double height;
            if (p1.Y == p2.Y)
                height = Math.Abs(p2.Y - p3.Y);
            else
                height = Math.Abs(p1.Y - p2.Y);

            return sum / 2 * height;
        }

        //ToString
        public override string ToString()
        {
            return "Trapezoid" + base.ToString();
        }
    }
}
