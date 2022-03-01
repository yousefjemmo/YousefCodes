using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace calculate_factorial
{
    internal class factorial
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a number (non negative number): ");
            double number = Convert.ToInt32(Console.ReadLine());
            

            try
            {
                while (number <= 180)
                {

                    //Result WithOut Recvursively
                    double ResultWithOutRecvursively = GetFactorial(number);
                    Console.WriteLine("{0}! = {1}", number, ResultWithOutRecvursively);

                    //Result With Recursively
                    double ResultWithRecursively = GetRecursivelyFactorial(number);
                    Console.WriteLine("{0}! = {1}", number, ResultWithRecursively);
                    number++;
                }

                for (double i = number; i <= 180; i++) ;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); 
            }

            
        }


        // Method without Recursively
        private static double GetFactorial(double number)
        {
            double fac = 1;
            if (number < 0)
            {
                throw new ArgumentException("Cannot compute factorial of negative integer");
            }
            else
            {
                for (double counter = number; counter >= 2; counter--)
                {
                    fac = fac * counter;
                }

            }
            return fac;
        }
        
        //Method with Recursively

        private static double GetRecursivelyFactorial(double number)
        {

            if (number < 0)
            {
                throw new ArgumentException("Cannot compute factorial of negative integer");
            }
            if (number == 0)
            {
                return 1;
            }
            return number * GetRecursivelyFactorial(number - 1);
        }


    }
}

