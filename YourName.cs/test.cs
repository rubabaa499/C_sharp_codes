using System;
using System.Collections.Generic;
using System.Text;

namespace YourName.cs
{
    class test
    {
        static void Main (string[]args)

        {
            Program prog1 = new Program();
            Program prog2 = new Program();
            Program prog3 = new Program();

            prog1.set_name("Rubaba Binte Rahman");
            prog1.set_id("20-42182-1");
            prog1.set_cgpa("3.69F");
            prog1.set_uni("AIUB");
            prog1.set_prg("BSC.CSE");

            Console.WriteLine(prog1.get_name());
            Console.WriteLine(prog1.get_id());
            Console.WriteLine(prog1.get_cgpa());
            Console.WriteLine(prog1.get_uni());
            Console.WriteLine(prog1.get_prg());

            Console.WriteLine();













        }
    }
}
