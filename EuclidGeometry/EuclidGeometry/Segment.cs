using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidGeometry
{
    public class Segment
    {
        public Point A;
        public Point B;

        public Segment(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public double Length
        {
            get
            {
                var dx = A.X - B.X;
                var dy = A.Y - B.Y;

                return Math.Sqrt(dx * dx + dy * dy);
            }
        }
        public Segment RotateSegmentAroundThisPoint(Point AroundThisPoint, double myDegree)
        {
            Segment mySegment = new Segment(A, B);
            Segment newSegment = new Segment(mySegment.A.RotateAroundPoint(AroundThisPoint, myDegree), mySegment.B.RotateAroundPoint(AroundThisPoint, myDegree));
            return newSegment;
        }
    }
}
