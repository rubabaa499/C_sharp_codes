using System;
using System.Collections.Generic;
using System.Text;

namespace inheritencecls
{
    class employee:person //inheritence
    {
        
        private Account acc;


        public employee()
        {
            Console.WriteLine(" Empty employee");
        }
       
        public employee (string name, string dob, Account acc ): base( name, dob)
        {

            Console.WriteLine("Prameterized employee");
            this.acc = acc;
            
        }

        public void setAcc(string name)
        {
            this.name = name;

        }

       
       public void display()
        {
            Console.WriteLine("name:" +" "+ name);
            Console.WriteLine("dob:" +" " + dob);
            
        }

       




    }
}