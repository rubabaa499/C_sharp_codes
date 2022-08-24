using System;

namespace Lbtask4
{
    class Program


    {


        public static void Addition(int id, int lastpart)
        {

            id = id + lastpart;
            Console.WriteLine("inside the method additon : " + id);
        }

        public static void Multiply(ref int id, int lastpart)
        {

            id = id * 10;
            Console.WriteLine("inside the Method Multiply : " + id);
        }
        //out parameter
        public static void OutPara(out int a)
        {
            

            a = 186;
            Console.WriteLine(a);


        }

        //params
        public static void Param(params int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {

                Console.Write(b[i] + " ");
            }
        }


        public static void Add(int x, double y)
        {
            Console.WriteLine(x + y);
        }



















        static void Main(string[] args)
        {

            int id = 182;
            int lastpart = 1;
            Console.WriteLine("  Pass BY Value   ");
            Console.WriteLine("before using method Addition :" + id); //for out parameter
            Addition(id, lastpart);
            Console.WriteLine("After using method Addition :" + id);
            Console.WriteLine();
            Console.WriteLine("  Pass BY Reference  ");
            Console.WriteLine("before using method Multiply :" + id); //for out parameter
            Multiply(ref id, lastpart);
            Console.WriteLine("After using method Multiply : " + id);
            Console.WriteLine();





           
             

            

           
        }










    }









    }
}

