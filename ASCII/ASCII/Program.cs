using System;
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

            string title = "";
            bool titleIsValid = false;

            while (!titleIsValid)
            {
                try
                {
                    title = AskForTitle();
                    CheckIfContainsNumber(title);
                    titleIsValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error, not allowed to use numbers.");
                    
                }
            }

            int inputNumber = 0;
            bool inputNumberIsValid = false;
            while (!inputNumberIsValid)
            {
                try
                {
                    inputNumber = AskForWidth();
                    CheckWidth(inputNumber);
                    inputNumberIsValid = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Error. The minimum number you can add is 5 and maximuime is 25. Try again:");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You only allowed to enter a number");
                    

                }
            }
            string SymbolInput = ""; 
            bool SymbolIputIsValid = false;
            while (!SymbolIputIsValid)
            {
                try
                {
                    SymbolInput = AskForSymbol();
                    CheckSymbol(SymbolInput);
                    SymbolIputIsValid = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Please insert only one Symbol");

                }
            }

            Console.WriteLine(title);

            Console.WriteLine( GetCliff(inputNumber, SymbolInput));
          
        }

        public static string AskForTitle()
        {
            Console.Write("Please insert a title: ");
            return Console.ReadLine();
        }

        public static void CheckIfContainsNumber(string input)
        {
            foreach (char userinput in input)
            {
                if (char.IsDigit(userinput))
                {
                    throw new FormatException();
                }
            }
            
        }

        public static int AskForWidth()
        {
            Console.Write("Please insert a width: ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        public static void CheckWidth(int input)
        {
            if (input < 5 || input > 25)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public static string AskForSymbol()
        {
            Console.Write("Please insert ONE Number or ONE Charachter or ONE Special Character: ");
            string input = Console.ReadLine();
            return input;
        }

        public static void CheckSymbol(string input)
        {

            if (input.Length > 1)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private static string GetCliff(int width, string UserSymbol)
        {
            int i, j;
            string results = "";
            for (i = width; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    results = results + UserSymbol;   
                }
                results += System.Environment.NewLine;
            }
            return results;
        }
    }
}