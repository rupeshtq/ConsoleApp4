using System;

namespace AbstractClassShape
{
    public abstract class Shape
    {
        public abstract void CalculateArea();


    }
    public class Circle : Shape
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void CalculateArea()
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine("Area of Circle is = " + area);
        }
    }

    public class Rectangle : Shape
    {
        double length, breadth;
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void CalculateArea()
        {
            double area = length * breadth;
            Console.WriteLine("Area of Rectangle is = " + area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of circle");
            double rad = Convert.ToDouble(Console.ReadLine());
            Circle c = new Circle(rad);
            c.CalculateArea();
            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine("Enter Length and Breadth of Rectangle");
            double len = Convert.ToDouble(Console.ReadLine());
            double bred = Convert.ToDouble(Console.ReadLine());
            Rectangle r = new Rectangle(len, bred);
            r.CalculateArea();
        }
    }
}
