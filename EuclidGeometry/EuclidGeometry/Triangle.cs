using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidGeometry
{
    public class Triangle
    {
        public Point A;
        public Point B;
        public Point C;
        public Segment segmentAB;
        public Segment segmentBC;
        public Segment segmentAC;
        

        public Triangle(Point a, Point b, Point c, Segment ab, Segment bc, Segment ac)
        {
            A = a;
            B = b;
            C = c;

            ab = new Segment(a, b);
            bc = new Segment(b, c);
            ac = new Segment(a, c);
            segmentAB = ab;
            segmentBC = bc;
            segmentAC = ac;
            
        }
        public double Area
        {
            get
            {
                var semiPerimeter = (segmentAB.Length+segmentBC.Length+segmentAC.Length)/2;
                return Math.Sqrt(semiPerimeter*(semiPerimeter-segmentAB.Length)*(semiPerimeter-segmentBC.Length)*(semiPerimeter-segmentAC.Length));
            }
        }
    }
}
