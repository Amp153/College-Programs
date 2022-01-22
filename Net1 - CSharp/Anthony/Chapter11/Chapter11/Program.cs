using System;



namespace Chapter11
{
    class Program
    {
        static void Main(string[] args)
        {
            //check out Point
            /*Point p = new Point(10, 20);
            Console.WriteLine(p);*/

            Quad q1 = new Quad(1,1,2,2,3,3,4,4);
            Console.WriteLine(q1);

            Point p = new Point(1,2);
            Quad q2 = new Quad(p, new Point(2, 3),
                new Point(3, 4), new Point(5, 6));
            Console.WriteLine(q2);

            Trap t1 = new Trap(1, 1, 2, 2, 3, 3, 4, 4);
            Console.WriteLine(t1);
            Console.WriteLine("Area of the trapezoid is {0}",t1.Area());

            Rec r1 = new Rec(1, 1, 2, 2, 3, 3, 4, 4);
            Console.WriteLine(r1.Area());


            //Quad q3 = new Square(); //can be done but will only have stuff from the quad class


            // Square s1 = new Quad(); //cant be done

            Console.ReadKey();
        }
    }
}
