using System;

namespace ClassRectangleApp
{
    public class Rectangle
    {
        double side1, side2;
        public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Первая сторона: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вторая сторона: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Площадь: {0}\nПериметр: {1}", rectangle.Area, rectangle.Perimeter);
        }
    }
}
