using System;
//function without return type 
namespace FunctionDemo
{
    /*  class Program
      {
          public void SHOW()
          {
              Console.WriteLine("THIS IS NON PARAMETER FUNCTION");
          }
          static void Main(string[] args)
          {

              Program p = new Program();
              p.SHOW();


          }
      }
  */

    //using parameter but no return type 

    class program
    {
        public void show (String massage)
        {
            Console.WriteLine("HELLO" + massage);

        }
        static void Main(string[] args)
        {
            program P = new program();
            P.show("RUPESH ");//CALLIG FUNCTION
            

            
        }
    }

}