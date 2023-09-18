using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasProgram
{
    internal class Rectangle
    {
        public double Area(double h, double w)
        {
            return h * w;
        }

        public double Perimeter(double h, double w)
        {
            return (2 * h) + (2 * w);
        }

    }
}
