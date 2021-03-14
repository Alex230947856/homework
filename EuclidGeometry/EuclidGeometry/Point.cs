using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidGeometry
{
    public class Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool IsInsideSegment(Segment s)
        {
            return Math.Abs((X - s.A.X) * (s.B.Y - Y) - (Y - s.A.Y) * (s.B.X - X)) < 1e-8
                && (X - s.A.X)* (s.B.X - X) + (Y - s.A.Y)* (s.B.Y - Y) > -1e-8;
        }
    }
}
