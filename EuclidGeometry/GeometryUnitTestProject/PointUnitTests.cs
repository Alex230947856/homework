using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuclidGeometry;

namespace GeometryUnitTestProject
{
    [TestClass]
    public class PointUnitTests
    {
        [TestMethod]
        public void ConsturtorTest()
        {
            var p = new Point(1, -3);

            Assert.AreEqual(1, p.X);
            Assert.AreEqual(-3, p.Y);
        }

        [TestMethod]
        public void IsInsideSegmenttest()
        {
            var s = new Segment(new Point(1, 1), new Point(5, 3));

            var m1 = new Point(3, 2);
            var m2 = new Point(-1, 0);
            var m3 = new Point(2, 3);

            Assert.IsTrue(m1.IsInsideSegment(s));
            Assert.IsFalse(m2.IsInsideSegment(s));
            Assert.IsFalse(m3.IsInsideSegment(s));
        }
        [TestMethod]
        public void RotateTestPoint()
        {
            Point rPoint = new Point(5, -2);
            Point n1 = new Point(6,-1);

            double d1 = 180.0;
            double d2 = 90.0;
            double d3 = 45;
            double d6 = -45;
            double d7 = 765;

            Assert.AreEqual(4, n1.RotateAroundPoint(rPoint, d1).X);
            Assert.AreEqual(-3, n1.RotateAroundPoint(rPoint, d1).Y);

            Assert.AreEqual(4, n1.RotateAroundPoint(rPoint, d2).X);
            Assert.AreEqual(-1, n1.RotateAroundPoint(rPoint, d2).Y);

            Assert.AreEqual(5, n1.RotateAroundPoint(rPoint, d3).X);
            Assert.AreEqual(Math.Round(Math.Sqrt(2)-2, 10), n1.RotateAroundPoint(rPoint, d3).Y);

            Assert.AreEqual(Math.Round(Math.Sqrt(2)+5, 10), n1.RotateAroundPoint(rPoint, d6).X);
            Assert.AreEqual(-2, n1.RotateAroundPoint(rPoint, d6).Y);

            Assert.AreEqual(5, n1.RotateAroundPoint(rPoint, d7).X);
            Assert.AreEqual(Math.Round(Math.Sqrt(2)-2, 10), n1.RotateAroundPoint(rPoint, d7).Y);

            Assert.AreEqual(6, n1.RotateAroundPoint(rPoint, 0).X);
            Assert.AreEqual(-1, n1.RotateAroundPoint(rPoint, 0).Y);

            Assert.AreEqual(6, n1.RotateAroundPoint(n1, 35).X);
            Assert.AreEqual(-1, n1.RotateAroundPoint(n1, 35).Y);
        }
    }
}
