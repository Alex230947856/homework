using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidGeometry
{
    public static class Geometry
    {
        public static Segment CreateSegment(Point a, Point b)
        {
            var segment = new Segment(a, b);

            return segment;
        }
        public static Triangle CreateTriangle(Point a, Point b, Point c)
        {
            Segment ab = new Segment(a, b);
            Segment bc = new Segment(b, c);
            Segment ac = new Segment(a, c);
            var triangle = new Triangle(a, b, c);

            if ((a.IsInsideSegment(triangle.segmentBC) || b.IsInsideSegment(triangle.segmentAC) || c.IsInsideSegment(triangle.segmentAC)) == false)
                return triangle;
            else
                throw new ArgumentException("Triangle is incorrect");
        }
    }
}
