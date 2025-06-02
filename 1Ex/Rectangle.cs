using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Ex
{
    internal class Rectangle
    {
        double side1;
        double side2;

        public Rectangle(double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }

        public double Area()
        {
            return Side1 * Side2;
        }

        public double Perimeter()
        {
            return 2 * (Side1 + Side2);
        }

        public override string ToString()
        {
            return $"Прямоугольник: Сторона 1 = {Side1}, Сторона 2 = {Side2}, Площадь = {Area()}, Периметр = {Perimeter()}";
        }
    }
}
