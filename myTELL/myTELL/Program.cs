using System;

namespace myTELL
{
    class Program
    {
        static void Main(string[] args)
        {

            test t1 = new test();
            test t2 = new test();
            test t3 = new test();

            t1.set_name("Rubaba Binte Rahman");
            t1.set_id("20-42182-1");
            t1.set_cgpa(3.69F);
            t1.set_uni("AIUB");
            t1.set_prg("BSC.CSE");

            Console.WriteLine(t1.get_name());
            Console.WriteLine(t1.get_id());
            Console.WriteLine(t1.get_cgpa());
            Console.WriteLine(t1.get_uni());
            Console.WriteLine(t1.get_prg());

            Console.WriteLine();

            test t2 = new test("Rubaba Binte Rahman", "20-42182-1", 3.69F, "AIUB", "BSC,CSE");
            t2.show();
            Console.WriteLine();

            test.t3 = new test(t2);
            t3.show();
            Console.ReadLine();

            test t4 = new test();
            t4.Cgpa = 3.82F;
            Console.WriteLine(t4.getCgpa());


        }
    }
}
