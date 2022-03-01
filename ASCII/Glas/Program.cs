
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    internal class ASCII
    {
        public static void Main(string[] args)
        {
            int number = 0;            
            bool InputNumberIsValid = false;

            while (!InputNumberIsValid)
            {
                try
                {
                    number = AskForNumber();
                    CheckIfNumberIsInRange(number);
                    CheckIfNumberIsOdd(number);
                    InputNumberIsValid = true;

                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The minimum number is 7 and maximumum is 71.");

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("You are only allowed to enter numbers");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("The number is too big");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("You are not allowed to write even numbers");
 
                }

            }
           

            Console.WriteLine(number);


            string glass = GetHead(number) + GetTopBody(number) + GetLowerBody(number) + GetLegs(number) + GetBottom(number);
            Console.Write(glass);

        }
        public static int AskForNumber()
        {
            Console.Write("Please insert a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }


        public static void CheckIfNumberIsInRange(int input)
        {
            if (input < 7 || input > 71)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public static void CheckIfNumberIsOdd(int input)
        {
            if (input % 2 == 0)
            {
                throw new ArgumentException();
            }
            
        }

        private static string GetHead(int number)
        {
            int i;
            string results = "";
            for (i = 1; i <= number; i++)
            {
                results = results + "-"; 

            }
            results += System.Environment.NewLine;
            return results;
        }

        public static string GetTopBody(int number)        
        {
            int i, j;
            string results = "";
            for (i = number / 2 - 1; i >= 1; i--)
            {
                
                for (j = number / 2 -1 ; j > i; j--)
                {
                    results += " ";
                }
                results += "\\  ";

                for (j = 1; j < (i * 2); j++)
                {
                    results += " ";
                }


                if (i > 0)
                {
                    results += "/  ";
                }

                results += System.Environment.NewLine;
            }
            return results;
            
        }

        public static string GetLowerBody(int number)
        {
            int i, x;
            string results = "";
            for (x = number / 2 - 1; x >= 1; x--)
            {
                for (i = 1; i < number / 2; i++)
                {
                    results += " ";

                }
                results += "| |";
                results += System.Environment.NewLine;
            }
            return results;
        }


        public static string GetLegs(int number)
        {
            string results = "";
;           results += "/   \\".PadLeft(number / 2 -1 + 4, ' ');
            results += System.Environment.NewLine;
            return results;
        }

        private static string GetBottom(int number)
        {
            int i;
            string results = "";
            results += " ";
            for (i = 1; i <= number - 2; i++)
            {
                results = results + "-";
            }
            results += System.Environment.NewLine;
            return results;
 
        }
    }
}
