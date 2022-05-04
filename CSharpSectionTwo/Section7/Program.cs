using System;

namespace Section7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Convert this value into "short" type (assign into another short type of variable)

            byte a = 10;

            short a1;

            a1 = a;

            Console.WriteLine(a1);

            //Convert this value into "short" type (assign into another short type of variable)

            int b = 10;

            short b1;

            b1 = (short)b;

            Console.WriteLine(b1);


            //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse

            string c = "10.34";

            double c1;

            c1 = double.Parse(c);

            Console.WriteLine(c1);



            //Convert this value into "string" type (assign into another string type of variable)

            decimal d = 10;

            Console.WriteLine(Convert.ToString(d));



            Console.ReadKey();



        }

    }
}
    