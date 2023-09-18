using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasProgram
{
    internal class Triangle
    {
        public double Area(double a, double b, double c)
        {
            double s = (a+b+c)/2;
            return Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        }

        public double Perimeter(double a, double b, double c)
        {
            return a+b+c;
        }
    }
}
