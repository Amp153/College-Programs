using System;

namespace Chapter10Example
{
    class Rectangle
    {
        private double length;
        private double width;
        //private double Width { get; set; }

        public static string color;

    /*    public Rectangle() 
        {
            Length = 1;
            Width = 1;
        }*/
        public Rectangle()
            :this(1,1)
        {
        }

        public Rectangle(double l, double w)
        {
            Length = 1;
            Width = w;
        }

        //properties (property procedures)
        public double Length 
        {
            get 
            {
                return length;
            }

            set 
            {
                if (value > 0 && value < 20)
                    length = value;
                else
                    throw new ArgumentOutOfRangeException("length", value,
                        "length must be between 0 and 20");
            }
        }
        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                if (value > 0 && value < 20)
                    width = value;
                else
                    throw new ArgumentOutOfRangeException("width", value,
                        "width must be between 0 and 20");
            }
        }

        public double Area 
        {
            get
            {
                return Length * Width;
            }
        }

        public double Perimeter{
            get{
                return 2 * Length + 2 * Width;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3}\n{4}: {5:f4}\n{6}: {7:f4}",
                "Length",Length,"Width",Width,"Perimeter",Perimeter,"Area",Area);
        }

    }
}
