using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AreasProgram
{
    [TestFixture]
    internal class AreaTest
    {
        [Test]
        public void CircleTest()
        {
            Circle c = new Circle();
            double r = 5;
            double expectedValue = 78.5;
            double actualValue = c.Area(r);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void RectangleTest()
        {
            Rectangle r = new Rectangle();
            double h = 5;
            double w = 6;
            double expectedValue = 30.0;
            double actualValue = r.Area(h, w);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TriangleTest()
        {
            Triangle t = new Triangle();
            double a = 5;
            double b = 4;
            double c = 3;
            double expectedValue = 6.0;
            double actualValue = t.Area(a, b, c);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
