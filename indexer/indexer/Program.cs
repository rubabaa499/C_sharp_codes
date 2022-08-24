using System;

namespace indexer
{
    class Program
    {
        //indexer
        private string[] ar1 = new string[3];

        public string this[int i]
        {
            get { return ar1[i]; }
            set { ar1[i] = value; }
        }

        //indexer overloading
        public string this [string name]
        {
            get
            {
                foreach( string p1 in ar1)
                {
                    if (p1.ToLower() == name.ToLower())
                    {
                        return p1.ToUpper();

                    }
                }
                return null;
            }


        }









        static void Main(string[] args)
        { //for indexer
            Program p1 = new Program();
            p1[0] = "ABC";
            p1[1] = "DEF";
            p1[2] = "GHI";


            for (int i=0; i<3; i++)
            {
                Console.WriteLine(p1[i]);
            }

            //for indexer overloading
            Console.WriteLine(p1["ghi3"]);

        }
    }
}