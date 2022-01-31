using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// cheked and uncheked example
namespace ExceptionHandling
{
   //checked exmple using cheked
        class Program
        {
            static void Main(string[] args)
            {
                checked
                {
                    int val = int.MaxValue;
                    Console.WriteLine(val + 2);
                }
            }
  
    
         }

    class program
    {

      
        //uncheked example using uncheked
            static void Main(string[] args)
            {
                unchecked
                {
                    int val = int.MaxValue;
                    Console.WriteLine(val + 2);
                }
            }
        }

    }
  }


