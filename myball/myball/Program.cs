using System;

namespace myball
{
    class Program
    {
        static void Main(string[] args)
        {
            YourName yourname1 = new YourName();

            //DEFAULT

            yourname1.set_name("Rubaba Binte Rahman");
            yourname1.set_id("20-42182-1");
            yourname1.set_cg(3.69F);
            yourname1.set_prog("BSC.CSE");
            yourname1.set_uni("AIUB");

            Console.WriteLine(yourname1.get_name());
            Console.WriteLine(yourname1.get_id());
            Console.WriteLine(yourname1.get_cgpa());
            Console.WriteLine(yourname1.get_prog());
            Console.WriteLine(yourname1.get_uni());

            Console.WriteLine();
            //PARAMETERIZED

            YourName yourname2 = new YourName("X", "Y", 3.54F, "CS", "asdad");
            yourname2.display();

            Console.WriteLine();
            //COPY 
            YourName yourname3 = new YourName(yourname1);
            yourname3.display();


            Console.WriteLine("property");
            YourName yourname4 = new YourName();
            yourname4.Cgpa = 3.82F;
            Console.WriteLine(yourname4.get_cgpa());


            Console.WriteLine("Auto property");
            YourName yourname5 = new YourName();
            yourname5.CGpa = 3.82F;
            Console.WriteLine(yourname5.CGpa);

            Console.WriteLine("static property");

            YourName.PROGRAM = "Architecture" ;
            Console.WriteLine(YourName.PROGRAM);



            Console.ReadKey();




        }
    }
}
