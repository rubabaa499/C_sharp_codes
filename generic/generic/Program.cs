using System;

namespace generic
{
    class GenericClass <T>
    {

        public T test;
         
        public void settest(T test)
        {
            this.test = test;
        }

        public T gettest ()
        {
            return test;
        }




    }












    class Program
    {
        static void Main(string[] args)
        {

            GenericClass<string> gc1 = new GenericClass<string>();
            gc1.settest("Hello There!!");
            Console.WriteLine(gc1.gettest());


            GenericClass<int> gc2 = new GenericClass<int>();
            gc2.settest(69);
            Console.WriteLine(gc2.gettest());

            GenericClass<double> gc3 = new GenericClass<double>();
            gc3.settest(699.094);
            Console.WriteLine(gc3.gettest());




            Console.ReadKey();
        }
    }
}
