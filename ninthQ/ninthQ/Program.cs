using System;
using System.Collections;

namespace ninthQ
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList alist = new ArrayList();
            alist.Add(5);
            alist.Add("Rubaba");
            alist.Add(90);

            ArrayList blist = new ArrayList() { 100, "hello" };
            alist.AddRange(blist);

            int a = (int)alist[0];
            string b = (string)alist[1];
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);

            alist.Insert(1, "Raku");
            alist.Remove(90);
            alist.RemoveAt(0);



            Console.WriteLine("Count:  "+ alist.Count);
            Console.WriteLine("Capasity:  " + alist.Capacity);
            Console.WriteLine("Check for an element: " + alist.Contains("Raku"));
            Console.WriteLine("Check for an element: " + alist.Contains(90));


            foreach (var i in alist )
            {
                Console.WriteLine(i);
            }


            
        }
    }
}
