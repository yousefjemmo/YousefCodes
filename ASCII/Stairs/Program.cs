using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    internal class Stairs
    {
        public static void Main(string[] args)
        {
            int size = 0;
            bool InputNumberIsValid = false;

            while (!InputNumberIsValid)
            {
                try
                {
                    size = AskForNumber();
                    CheckIfNumberIsInRange(size);
                    InputNumberIsValid = true;

                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The minimum number is 4 and maximumum is 50.");

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("You are only allowed to enter numbers");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("The number is too big");
                }

            }

            bool InputDirectionIsValid = false;
            string InputDirection = "";

            while (!InputDirectionIsValid)
            {
                 InputDirection = AskForDirection();

                if (InputDirection == "u" || InputDirection == "d")
                {
                    Console.WriteLine(InputDirection);
                    InputDirectionIsValid = true;
                }
                else
                {
                    Console.WriteLine("Either u or d");
                }
            }

            var jump = true;
            for (int repeatedTimes = 0; repeatedTimes < size; repeatedTimes++)
            {
               
                 Console.WriteLine(FullStairs(size, repeatedTimes, jump));
                
                if (jump)
                {
                    jump = false;
                }
                else
                {
                    jump = true;
                }

                if (InputDirection == "u")
                {
                    
                }


            }
                



        }

        public static int AskForNumber()
        {
            Console.Write("Please insert a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void CheckIfNumberIsInRange(int input)
        {
            if (input < 4 || input > 50)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public static string AskForDirection()
        {
            Console.Write("Please insert a direction. u = Upwards || d = Downwards: ");
            return Console.ReadLine();
        }

        public static string AddStepWithoutBall(int spaces)
        {            
            string extraSpace = "";

            for (int i = 0; i < spaces; i++)
            {
                extraSpace += "  ";
            }
            string result = "_";
            string newline = System.Environment.NewLine;
            string space = " ";
            string results = "|";            
            
            string x = result + newline + extraSpace+  space + results;           
            return x;
            
        }

        public static string AddStepWithFallingBall(int spaces)
        {

            string extraSpace = "";

            for (int i = 0; i < spaces; i++)
            {
                extraSpace += "  ";
            }
            string result = "_o";
            string newline = System.Environment.NewLine;
            string space = " ";
            string results = "|";

            string x = result + newline + extraSpace + space + results;
            return x;
        }
        public static string AddStepWithJumpingBall(int spaces)
        {
            string extraSpace = "";

            for (int i = 0; i < spaces; i++)
            {
                extraSpace += "  ";
            }
            string result = "_ °";
            string newline = System.Environment.NewLine;
            string space = " ";
            string results = "|";

            string x = result + newline + extraSpace + space + results;
            return x;
        }

        public static string FullStairs(int size, int postion, bool jump)
        {
            string results = "";          
            
            for (int i = 0; i < size; i++)
            {
                if (i == postion)
                {
                    if (jump)
                    {
                        results += AddStepWithFallingBall(i);
                    }
                    else
                    {
                        results += AddStepWithJumpingBall(i);
                    }
                }
                else
                {
                    results += AddStepWithoutBall(i);
                }
            }
            return results;
        }

      

    }
}
