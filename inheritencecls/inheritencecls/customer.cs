using System;
using System.Collections.Generic;
using System.Text;

namespace inheritencecls
{
    class customer:person
    {

        private Account acc;

        public customer()
        {
            Console.WriteLine("Empty customer");
        }

        public customer (string name, string dob, Account acc) : base( name, dob)
        {
            Console.WriteLine("Parameterized customer");
            this.acc = acc;


        }


        

        public void setAcc(string name)
        {
            this.name = name;
         
        }

      
       public void display()
        {
            Console.WriteLine("name:" + " " + name);
            Console.WriteLine("dob" + " " + dob);
        }



    }
}
