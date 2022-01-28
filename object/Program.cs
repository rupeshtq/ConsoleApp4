using System;

namespace cobject
{
    class date
    {
        public int day, month, year;
    }
    class maniplutedate
    {
        public void acceptdate(date d)
        {
            Console.WriteLine("ente day");
            d.day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the  month ");
            d.month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter year ");
            d.year = Convert.ToInt32(Console.ReadLine());




        }

        public void Printdate(date d)
        {
            Console.WriteLine(d.day + "/" + d.month + "/" + d.year);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            date d = new date();

            maniplutedate obj = new maniplutedate();

            obj.acceptdate(d);
            obj.Printdate(d);



        }
    }
}
