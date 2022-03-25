using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int age = 0;


            bool InputIsValid = false;

            while (!InputIsValid)
            {
                try
                {
                    input = AskForName();
                    CheckIfInputISCorrect(input);
                    InputIsValid = true;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Try the name again!!");
                }
            }

            bool AgeIsValid = false;

            while (!AgeIsValid)
            {
                try
                {
                    age = AskForAge();
                    AgeIsValid = true;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("You only allowed to enter numbers");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Number is too big");
                }
            }

            User UserInput = new User(input, age);
            Console.WriteLine(UserInput.UserName);
            Console.WriteLine(UserInput.IsAdult);
        }




        public static string AskForName()
        {
            Console.WriteLine("Please enter your name:");
            return Console.ReadLine();
        }


        public static void CheckIfInputISCorrect(string input)
        {           
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c) && c != '-')
                {
                    throw new ArgumentException();
                }
            }
            
        }

        public  static int AskForAge()
        {
            Console.WriteLine("Please enter your age:");
            int AgeInput = Convert.ToInt32(Console.ReadLine());
            return AgeInput;
        }

        
    }
}