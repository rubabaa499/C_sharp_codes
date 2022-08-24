using System;

namespace inheritencecls
{
    class Program
    {
        static void Main(string[] args)
        {

            Account Emp = new Account(01, 60000, "Employee Account");
            Console.WriteLine("....calling emp acc.... ");
            Emp.display();

            Console.WriteLine("      ");

            Account Cus = new Account(02, 40000, "Customer Account");
            Console.WriteLine("....Calling cus acc.... ");
            Cus.display();


            Console.WriteLine(" ");
            Console.WriteLine("    ----****----    ");


            //employee empty constructor
            employee e1 = new employee();
            e1.setName("Rubaba");
            e1.setDob("4th january 1999");
            

            
            Console.WriteLine("NAME:" + e1.getName());
            Console.WriteLine("DOB:" + e1.getDob());
            
            e1.display();
            Console.WriteLine(" ");



            //customer empty constructor
            customer c1 = new customer();

            c1.setName("Raju");
            c1.setDob("21st april 2006");
            

            
            Console.WriteLine("NAME:" + c1.getName());
            Console.WriteLine("DOB:" + c1.getDob());
            c1.display();

            Console.WriteLine("   ");
            Console.WriteLine("   .....****......   ");

            //parameterized cons
            employee e2 = new employee("Rubaba", "4th january 1999", Emp);
            Console.WriteLine("  ....Employee...  ");
            Console.WriteLine("NAME:" + e2.getName());
            Console.WriteLine("DOB:" + e2.getDob());
            e2.display();
            //parameterized cons
            customer c2 = new customer("Raju","20-43677-1", Cus);
            Console.WriteLine("  ----Customer----  ");
            Console.WriteLine("NAME:" + c2.getName());
            Console.WriteLine("DOB:" + c2.getDob());
            c2.display();




        }
    }
}
