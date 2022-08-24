using System;
using System.Collections.Generic;
using System.Text;

namespace myball
{
    class YourName
    {
        private string name;
        public string id;
        protected float cgpa;
        internal string university;
        private static string program;

        //property
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }


        }
        //automatic property
        public float CGpa
        {
            get; set;
        }

        //static property

        public static float PROGRAM
        {
            get { return program; }
            set { program = value; }
        }



        //PARAMETERIZED CONS
        public YourName(string n, string id, float cg, string varsity, string prog)
        {
            name = n;
            this.id = id;//private access modifier
            cgpa = cg;
            university = varsity;
            program = prog;
        }
        //DEFAULT CONS
        public YourName()
        {
            name = "";
            id = "";
            cgpa = 0;
            university = "";
            program = "";
        }
        //COPY CONS
        public YourName(YourName yourname)
        {
            name = yourname.name;
            id = yourname.id;
            cgpa = yourname.cgpa;
            program = yourname.program;
            university = yourname.university;
        }
        
        
        // EMPTY CONS
        static YourName()
        {

        }
        public void set_name(string n)
        {
            name = n;
        }
        public string get_name()
        {
            return name;
        }
        public void set_id(string id)
        {
            this.id = id;
        }
        public string get_id()
        {
            return id;
        }
        public void set_cg(float cg)
        {
            cgpa = cg;
        }
        public float get_cgpa()
        {
            return cgpa;
        }
        public void set_prog(string prog)
        {
            program = prog;
        }
        public string get_prog()
        {
            return program;
        }
        public void set_uni(string uni)
        {
            university = uni;
        }
        public string get_uni()
        {
            return university;
        }

        public void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
            Console.WriteLine(cgpa);
            Console.WriteLine(program);
            Console.WriteLine(university);
        }
























    }
}
