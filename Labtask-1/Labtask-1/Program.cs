using System;

namespace Labtask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My ID- 20-42182-1");

            //Implicit typecasting
            int myInt = 10;
            double myDouble = myInt;  

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);


            //Explicit typecasting

            double myDouble = 20.78;
            int myInt = (int)myDouble;  

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
            
            Console.ReadKey();
        }
    }
}
