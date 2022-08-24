using System;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] j_arr = new int[2][];

            j_arr[0] = new int[] { 2, 3, 4 };
            j_arr[1] = new int[] { 5, 6 };


            for (int i = 0; i < j_arr.Length; i++)
            //i, j -> index
            {
                for (int j = 0; j < j_arr[i].Length; j++)
                {
                    Console.WriteLine("j_arr[" + i + "] [" + j + "]: " + j_arr[i][j]);
                }
            }

            foreach (int[] i in j_arr)
            {
                foreach (int j in i)
                {
                    Console.WriteLine(j);
                }

            }

            Console.ReadKey();
        }
    }
    
}
