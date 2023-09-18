using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasProgram
{
    internal class Circle
    {
        public double Area(double r)
        {
            return (3.14 * Math.Pow(r, 2));
        }

        public double Perimeter(double r)
        {
            return 3.14 * (r*2);
        }
    }
}
