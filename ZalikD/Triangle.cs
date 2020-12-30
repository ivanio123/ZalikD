using System;

namespace ZalikD
{
    public class Triangle:Figure
    {
        private Point pointA;
        private Point pointB;
        private Point pointC;

        public double A
        {
            get { return pointA + pointB; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                A = value;
            }
        }

        public double B
        {
            get { return pointB + pointC; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                B = value;
            }
        }

        public double C
        {
            get { return pointC + pointA; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                C = value;
            }
        }

        public Triangle(Point pointA, Point pointB, Point pointC)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.pointC = pointC;
        }

        public override double Perimeter()
        {
            return A + B + C;
        }

        public override double Square()
        {
            var perimeter2 = Perimeter() / 2;
            return Math.Round(Math.Sqrt(perimeter2 * (perimeter2 - A) * (perimeter2 - B) * (perimeter2 - C)),2);
        }

        public override string ToString()
        {
            return $"AB:{this.A}\nAC:{this.B}\nBC:{this.C}\nPerimeter:{Perimeter()}\nSquare:{Square()}";
        }
    }
}