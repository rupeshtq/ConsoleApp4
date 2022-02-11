using System;

namespace GenricArrayy
{

    

    public class Demo
    {

        
        public void Display<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine("{0}:{1}", msg, value);
        }
    }

   
    public class Example
    {

       
        public static int Main()
        {

           
            Demo p = new Demo();

            
            p.Display<int>("Integer", 122);
            p.Display<char>("Character", 'H');
            p.Display<double>("Decimal", 255.67);
            return 0;
        }
    }
}
