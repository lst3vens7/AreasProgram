using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area;
            double perimeter;

            Console.WriteLine("What would you like to find the area and perimeter for?");
            Console.WriteLine("(c for circle, r for rectangle, t for triangle) ");

            string shape = Console.ReadLine();

            if (shape == "c")
            {
                Console.WriteLine("Please enter the radius of the circle: ");
                double r = Convert.ToDouble(Console.ReadLine());
                
                Circle circle = new Circle();

                area = circle.Area(r);
                perimeter = circle.Perimeter(r);

                Console.WriteLine("The area of the circle is: {0}", area);
                Console.WriteLine("The perimeter of the circle is: {0}", perimeter);
            }
            else if (shape == "r")
            {
                Console.WriteLine("Please enter the height of the rectangle: ");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the width of the rectangle: ");
                double w = Convert.ToDouble(Console.ReadLine());

                Rectangle rectangle = new Rectangle();

                area = rectangle.Area(h, w);
                perimeter = rectangle.Perimeter(h, w);

                Console.WriteLine("The area of the rectangle is: {0}", area);
                Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
            }
            else if (shape == "t") 
            {
                Console.WriteLine("Please enter the length of side a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the length of side b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the length of side c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                if (a <= b+c && b <= a+c && c <= a+b)
                {
                    Triangle triangle = new Triangle();

                    area = triangle.Area(a,b,c);
                    perimeter = triangle.Perimeter(a, b, c);

                    Console.WriteLine("The area of the triangle is: {0}", area);
                    Console.WriteLine("The perimeter of the triangle is: {0}", perimeter);
                }
                else
                {
                    Console.WriteLine("The inputted triangle is invalid!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadLine();
        }
    }
}
