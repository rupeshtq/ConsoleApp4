using System;

namespace ArrayDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };//Declaration and Initialization of array  

            //traversing array  
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
