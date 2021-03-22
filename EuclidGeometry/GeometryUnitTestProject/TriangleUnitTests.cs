using EuclidGeometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryUnitTestProject
{
    [TestClass]
    public class TriangleUnitTests
    {
        public Point a = new Point(0, 0);
        public Point b = new Point(4, 0);
        public Point c = new Point(0, 3);
        [TestMethod]
        public void ConstructorTestTriangle()
        {
            var segab = new Segment(a, b);
            var segbc = new Segment(b, c);
            var segac = new Segment(a, c);

            var tri = new Triangle(a, b, c);

            Assert.AreSame(a, tri.A);
            Assert.AreSame(b, tri.B);
            Assert.AreSame(c, tri.C);

            Assert.AreEqual (segab.Length, tri.segmentAB.Length);
            Assert.AreEqual (segbc.Length, tri.segmentBC.Length);
            Assert.AreEqual (segac.Length, tri.segmentAC.Length);
        }
        [TestMethod]
        public void AreaTestTriangle()
        {
            var tri = new Triangle(a, b, c);
            Assert.AreEqual(6.0, tri.Area);
        }
        
    }
}
