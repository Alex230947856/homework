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
    }
}
