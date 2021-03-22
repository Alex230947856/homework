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
        public Point RotateAroundPoint(Point AroundThisPoint, double myDegree)
        {
            double myRadians = (myDegree / 180) * Math.PI;
            Point myPoint = new Point(X, Y);
            if (myPoint.X == AroundThisPoint.X && myPoint.Y == AroundThisPoint.Y || myRadians==0)
            {
                return myPoint;
            }
            else 
            {
                Segment tempSegment = new Segment(AroundThisPoint, myPoint);
                double firstangle = Math.Asin((myPoint.Y - AroundThisPoint.Y) / tempSegment.Length);
                myRadians += firstangle;
                double newX = Math.Round((AroundThisPoint.X + Math.Cos(myRadians) * tempSegment.Length), 10);
                double newY = Math.Round((AroundThisPoint.Y + Math.Sin(myRadians) * tempSegment.Length), 10);
                Point newPoint = new Point(newX, newY);
                return newPoint;
            }
            
        }
    }
}
