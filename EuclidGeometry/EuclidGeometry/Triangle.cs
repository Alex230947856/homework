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
        

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;

            segmentAB = new Segment(a, b);
            segmentBC = new Segment(b, c);
            segmentAC = new Segment(a, c);

        }
        public double Area
        {
            get
            {
                var semiPerimeter = (segmentAB.Length+segmentBC.Length+segmentAC.Length)/2;
                return Math.Sqrt(semiPerimeter*(semiPerimeter-segmentAB.Length)*(semiPerimeter-segmentBC.Length)*(semiPerimeter-segmentAC.Length));
            }
        }

        public Triangle RotateTriangleAroundThisPoint(Point AroundThisPoint, double myDegree)
        {
            Triangle myTriangle = new Triangle(A, B, C);
            Triangle newTriangle = new Triangle(myTriangle.A.RotateAroundPoint(AroundThisPoint, myDegree), myTriangle.B.RotateAroundPoint(AroundThisPoint, myDegree), myTriangle.C.RotateAroundPoint(AroundThisPoint, myDegree));
            return newTriangle;
        }
    }
}
