

namespace Chapter11
{
    class Point
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        //constructor
        public Point(double xCoor, double yCoor)
        {
            X = xCoor;
            Y = yCoor;
        }

        public override string ToString()
        {
            return string.Format("({0:F1}, {1:F1})", X, Y);
        }
    }
}
