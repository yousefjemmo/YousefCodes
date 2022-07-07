using System;

namespace Seciton25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int num1 = 60, num2 = 45, num3 = 123;



            int biggest;

            if (num1 > num2)  

                if (num1 > num3)  //"num1 is greater than num2" and "num1 is greater than num3"

                    biggest = num1;

                else  //"num1 is greater than num2" and "num3 is greater than num1"

                    biggest = num3;

            else  //"num2 is greater than num1"

                if (num2 > num3)  //"num2 is greater than num1" and "num2 is greater than num3"

                biggest = num2;

            else  //"num2 is greater than num1" and "num3 is greater than num2"

                biggest = num3;

            Console.WriteLine(biggest);

           

        }
    }
    
}
