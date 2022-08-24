using System;

namespace iprac
{
    class Program : demo, Iaddition, Isubstraction 


    {
       
        


        static void Main(string[] args)
        {
            //demo d1 = new demo();
            
            Iaddition a1 = new demo();
            Isubstraction a2 = new demo();

            a1.operation(2, 5);
            a2.operation(5, 2);
            
            Console.ReadKey(); 

        }
    }
}
