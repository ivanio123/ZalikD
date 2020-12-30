using System;

namespace ZalikD
{
    public class Point
    {
        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public static double operator +(Point point1, Point point2)
        {
           return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }
        public override string ToString()
        {
            return $"({_x};{_y})";
        }
    }
}