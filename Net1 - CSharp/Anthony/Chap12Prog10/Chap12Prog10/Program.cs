using System;

namespace Chap12Prog10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape[] s = new Shape[5];
           /* Square s = new Square(3, 4, 7, 10);
            Console.Write(s.Name);
            Console.WriteLine(s.Area);

            Circle c = new Circle(3, 4, 10);
            Console.Write(c.Name);
            Console.WriteLine(c.Area);
            //c.Name = "circle";
            c.Radius = 5;
            Console.Write(c.Name);
            Console.WriteLine(c.Area);

            Console.WriteLine(c);*/

            // testing out sorting
            //TwoD[] ta = new TwoD[3];
            TwoD[] ta = new TwoD[4];
            //Won't work if multiple squares because will try to get squares compare to method
            ta[0] = new Circle(1, 3, 5); //TwoD();
            ta[1] = new Circle(5, 7, 12);
            ta[2] = new Square(5, 6, 7, 8);
            ta[3] = new Circle(5, 2, 15);


           // foreach (Circle c in ta)
             //   Console.WriteLine(c.Area);
            foreach (TwoD c in ta)
                Console.WriteLine(c.Area);

            Array.Sort(ta);
            //foreach (Circle c in ta)
              //  Console.WriteLine(c.Area);
            foreach (TwoD c in ta)
                Console.WriteLine(c.Area);

        }
    }
}
