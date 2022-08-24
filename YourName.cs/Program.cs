using System;

namespace YourName
{
    class Program
    {
        private string name;
        public string id;
        protected float cgpa;
        internal string university;
        private string Nameofprog;
    


        //DEAFAULT CONS
        public Program()
        {
            name = " ";
            id = " ";
            cgpa = 0;
            university = " ";
            Nameofprog = " ";
        }
        
        //PARAMETERIZED CONS
        public Program(string n, string id, float cg, string uni, string prg)
        {
            name = n;
            this.id = id;
            cgpa = cg;
            university = uni;
            Nameofprog = prg;

        }
        
        //COPY CONS
        public Program (Program program)
        {
            name = program.name;
            id = program.id;
            cgpa = program.cgpa;
            Nameofprog = program.Nameofprog;
            university = program.university;

        }

        //STATIC CONS
        static Program()
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


    }
