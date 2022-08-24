using System;

namespace labtsk1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My_Id- 20-42182-1");
            Console.ReadLine();
            //expilicit typecasting
            double myAge = 22.6;
            int newAge = (int)myAge;
            Console.WriteLine(myAge + " " + newAge);
            Console.ReadLine();
            //implicit typecasting
            int myInt = 9;
            double myDouble = myInt;  // Automatic casting: int to double

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

        }
    }
}
