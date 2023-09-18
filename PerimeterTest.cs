using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AreasProgram
{
    [TestFixture]
    internal class PerimeterTest
    {
        [Test]
        public void CircleTest()
        {
            Circle c = new Circle();
            double r = 2;
            double expectedValue = 12.56;
            double actualValue = c.Perimeter(r);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void RectangleTest()
        {
            Rectangle r = new Rectangle();
            double h = 5;
            double w = 6;
            double expectedValue = 22.0;
            double actualValue = r.Perimeter(h, w);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TriangleTest()
        {
            Triangle t = new Triangle();
            double a = 5;
            double b = 4;
            double c = 3;
            double expectedValue = 12.0;
            double actualValue = t.Perimeter(a, b, c);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
