using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Power
{
    internal class Power
    {

        
        public static void Main(string[] args)
        {
            
            int input = UserInput();

            var OverNumber10 = IsUserInputOverNumber10(input);
            if (OverNumber10)
            {
                Console.WriteLine("The number is over 10. That's not allowed");
                return;
            }

            var containsLetters = IsUserInputContainsLetters(input.ToString());
            if (containsLetters)
            {
                Console.WriteLine("The input contains letters");
            }
            
            List<string> ListofNumbersTheUserAdd = new List<string>();
            for (int i = 0; i < input; i++)
            {
                Console.Write($"please insert number {i + 1}: ");
                int input2 = GetInputFromUserwithAtleastTwoDigits(i);
                ListofNumbersTheUserAdd.Add(input2.ToString());

            }
            
            Console.WriteLine(Pow(ListofNumbersTheUserAdd));

        }

        public static int UserInput()
        {

            Console.WriteLine("How many numbers do you want to enter?");
            return GetIntFromUserInput();
        }

        public static int GetIntFromUserInput()
        {
            bool isNumber = false;
            int output;
            string input;

            do
            {
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out output);
                if (!isNumber)
                {
                    Console.Write("You are only allowed to enter numbers. Plz try again: ");
                }
            }
            while (!isNumber);
            return output;




        }

        private static bool IsUserInputOverNumber10(int input)
        {
            int max = 10;

            if (input > max)
            {
                return true;
            }
            return false;
        }

        public static double Pow(List<string> numbers)
        {
            double sum = 0;
            foreach (string num in numbers)
            {
                double power = double.Parse(num[num.Length - 1].ToString());
                double @base = double.Parse(num.Remove(num.Length - 1));
                sum += Math.Pow(@base, power);

            }
            return sum;
        }

        public static bool IsUserInputContainsLetters(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
                    
            }
            return false;

        }



        public static int GetInputFromUserwithAtleastTwoDigits(int i)
        {

            int input2;
            input2 = GetIntFromUserInput();
            while (input2 < 10)
            {

                Console.WriteLine("not allowed you must have at least 2 digits");
                Console.Write($"please insert number {i + 1}: ");
                input2 = GetIntFromUserInput();

            }



            return input2;
        }




    }
}

