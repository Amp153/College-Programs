

namespace Chapter11
{
    class Rec: Para
    {
        private double length;
        private double width;

        public Rec(double x1, double y1, double x2, double y2,
            double x3, double y3, double x4, double y4) :
            base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
            length = x4 - x1;
            width = y2 - y1;
        }

        public override double Area()
        {
            return (length) * (width);
        }
    }
}
