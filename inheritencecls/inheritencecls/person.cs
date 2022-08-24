using System;
using System.Collections.Generic;
using System.Text;

namespace inheritencecls
{
    class person
    {
        protected string name;
        protected string dob;


        public person()
        {

            Console.WriteLine("Empty person");


        }

        public person(string name, string dob)
        {

            Console.WriteLine("Parameterized person");
            this.name = name;
            this.dob = dob;


        }

        public void setName(string name)
        {
            this.name = name;

        }


        public void setDob(string dob)
        {
            this.dob = dob;

        }

        public string getName()

        { return name; }

        public string getDob()

        { return dob; }




    }
}

