using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону 1 прямоугольника:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону 2 прямоугольника:");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter()}");
            Console.ReadLine();
        }
    }
}
