using System;

namespace _21Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = ArrayOfMultiple(7, 5);

            foreach (double it in a)
            {
                Console.Write(it + " ");
            }            
            Console.WriteLine();


            double[] b = ArrayOfMultiple(12, 10);

            foreach (double it in b)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();
            
        }
        public static double[] ArrayOfMultiple(double num, int length)
        {

            double[] res = new double[length];

            for (int i = 0; i < length; i++)

                res[i] = num * (i + 1);

            return res;

        }


        
    }

    

}
