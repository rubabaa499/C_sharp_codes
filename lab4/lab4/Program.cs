using System;

namespace lab4
{
    class Program

    {  
        //Pass by value
        public static void add(int a)
        {

            a = a + 182;

            Console.WriteLine("Inside method addition is " + " "+ a);
        }
        //Pass by ref
        public static void  mul(ref int b)
        {


            b = b * 182;

            Console.WriteLine("inside ref method multiplication is" + " " + b);


        }
        //Out parameter
        public static void add(out int p)
        {
            p = 182;
            p= p+1;
            Console.WriteLine(p);


        }

        public static void mul(out int k)
        {
            k = 182;
            k = k * 1;
            Console.WriteLine(k);


        }









        //params
        public static void Param(params int[] q)
        {
            for (int i = 0; i < q.Length; i++)
            {

                Console.Write(q[i] + " ");
            }
        }









        static void Main(string[] args)
        {
            int a = 10;
            add(a);
            int b = 1;
            mul(ref b);
            Console.WriteLine("passing value for addition"+" " + a);
            Console.WriteLine("passing ref for multiplication " + " " + 1);
            int p;
            add(out p);
            
            Console.WriteLine("addition with out parameter" + " " + p);
            int k;
            mul(out k);
            Console.WriteLine("multiplication with out parameter" + " " + k);
            

            Console.ReadKey();
        }
    }
}
