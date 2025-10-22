using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace четвертое
{
    internal class Circle
    {

        public double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("ошибка");
                }
                else
                {
                    radius = value;
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public void GetArea()
        {
            double sum = Math.PI * radius * radius;
            Console.WriteLine($"Площадь круга: {sum}");
        }                                              
static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            circle.GetArea();
        }
    }
}
