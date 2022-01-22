//Base class

namespace Chapter11
{
    class Quad
    {
        //properties
        public Point p1 { get; private set; }
        public Point p2 { get; private set; }
        public Point p3 { get; private set; }
        public Point p4 { get; private set; }

        //constructor
        public Quad(double x1, double y1, double x2, double y2,
            double x3, double y3, double x4, double y4)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
            p3 = new Point(x3, y3);
            p4 = new Point(x4, y4);
        }

        public Quad(Point a, Point b, Point c, Point d)
        {
            p1 = a;
            p2 = b;
            p3 = c;
            p4 = d;
        }

        public override string ToString()
        {
            return string.Format("Coordinates are: \n{0}\n{1}\n{2}\n{3}",
                p1, p2, p3, p4);
        }
    }
}
