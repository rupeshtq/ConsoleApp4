using System;

namespace ParamArrayDemo
{
    class Program
    {

        public void Show(params int [] val)//params parameter
        {
            for(int i=0;i<val.Length;i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Show(1, 3, 3, 5, 2, 12, 4);


        }
    }
}
