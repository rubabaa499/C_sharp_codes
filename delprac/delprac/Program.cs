using System;

namespace delprac
{  //delegate


    public delegate void sampleD(int a, int b);


    class calculator
    {
        public void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("ADD: " + result);
        }

        public void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("SUBSTRACT: " + result);
        }

        public void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("multi: " + result);
        }






        public void Division(int a, int b)
        {
             double result = a / b;
            Console.WriteLine("division: " + result);
        }




    }

   






    class Program
    {


        static void samplefunc(sampleD s1,sampleD s2, sampleD s3, int a, int b)
        {

            s1(a, b);
            s2(a, b);
            s3(a, b);
                

        }







        static void Main(string[] args)
        {
            calculator c1 = new calculator();

            //together call
            samplefunc(c1.Addition, c1.Substraction, c1.Multiplication, 15, 5);
            
            
            
            
            //indivudiual call
           /* samplefunc(c1.Addition, 15, 5);
            samplefunc(c1.Substraction, 15, 5);
            samplefunc(c1.Multiplication, 15, 5);*/


            /*c1.Addition(5, 2); //usual

            single delegates
            sampleD del = c1.Addition;
            del(10, 5);
            del = c1.Substraction;
            del(10, 5);
            del = c1.Multiplication;
            del(10, 5);*/

            //multicast

            /*sampleD del = c1.Addition;
             del += c1.Substraction;
             del += c1.Multiplication;
             del += c1.Division;
             del(10, 4);*/











            Console.ReadKey();
        }
    }
}
