using System;

namespace rectangle
{
    class rectangle
    {   public  void Calculate(float  length,float breadth,out float area, out float perimeter)

        {
            area = length * breadth;
            perimeter = 2 * (length * breadth);

        }
        static void Main(string[] args)
        {
            float area, parameter;
            Console.WriteLine("enter the length of rectangle:");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the breadth of rectangle ");
            float breadth = float.Parse(Console.ReadLine());

            rectangle p = new rectangle();
            p.Calculate(length, breadth, out area, out parameter);

            Console.WriteLine(area);
           


        }
    }
}
