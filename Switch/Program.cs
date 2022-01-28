using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade;
            Console.WriteLine("enter grade");
            grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("excellent");
                    break;

                case 'B':
                    Console.WriteLine("very good ");
                    break;

                case 'C':
                    Console.WriteLine("good");
                    break;
                default:
                    Console.WriteLine("invalid grade");
                    break;
            }





        }

    }
}

