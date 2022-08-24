using System;
using System.Collections.Generic;
using System.Text;

namespace myTELL
{
    class test
    {
        private string name;
        public string id;
        protected float cgpa;
        internal string university;
        private string Nameofprog;


        //property 
        public float Cgpa
        { 
            get {return cgpa;}
            set { cgpa = value;}
         }
        
        
        //DEAFAULT CONS
        public test()
        {
            name = " ";
            id = " ";
            cgpa = 0;
            university = " ";
            Nameofprog = " ";
        }


        //PARAMETERIZED CONS
        public test(string n, string id, float cg, string uni, string prg)
        {
            name = n;
            this.id = id;
            cgpa = cg;
            university = uni;
            Nameofprog = prg;

        }
        //COPY CONS
        public test(test t)
        {
            name = test.name;
            id = test.id;
            cgpa = test.cgpa;
            Nameofprog = test.Nameofprog;
            university = test.university;

        }


        //STATIC CONS
        static test()
        {

            Console.WriteLine("Static Constructor");
        }
        //SET-GET METHOD

        public void set_name(string n)
        {
            this.name = name;
        }
        public void set_id(string id)
        {
            this.id = id;

        }
        public void set_cgpa(float cgpa)
        {
            this.cgpa = cgpa;
        }
        public void set_uni(string uni)
        {
            this.university = university;
        }
        public void set_prg(string prg)
        {
            this.Nameofprog = Nameofprog;
        }
        //get mathod
        public void get_name(string n)
        {
            return name;
        }
        public void get_id(string id)
        {
            return id;

        }
        public void get_cgpa(float cgpa)
        {
            return cgpa;
        }
        public void get_uni(string uni)
        {
            return university;
        }
        public void get_prg(string prg)
        {
            return Nameofprog;
        }

        public void show()
        {

            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Cgpa " + cgpa);
            Console.WriteLine("university " + university);
            Console.WriteLine("program " + Nameofprog);

        

        }

           

    }
}
