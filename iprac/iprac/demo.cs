using System;
using System.Collections.Generic;
using System.Text;

namespace iprac
{
    class demo:Iaddition, Isubstraction
    {
         void Iaddition.operation(int a, int b)
        {

            Console.WriteLine(a + b);

        }

        void Isubstraction.operation(int a, int b)
        {

            Console.WriteLine(a - b);

        }





    }

}
