using System.Collections;
using static OOP.User;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age = 0;
            int numberinput = 0;            
            bool NumberInputIsValid = false;
            string Gamename = "";




            while (!NumberInputIsValid)
            {
                try
                {
                    numberinput = AskForNumber();
                    CheckNumberInput(numberinput);
                    NumberInputIsValid = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number need to be between 1 and 12!");
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

            User[] userInputList = new User[numberinput];
            string[] GameNameList = new string[numberinput];

            for (int i = 0; i < numberinput; i++)
            {
                

                bool InputIsValid = false;
                while (!InputIsValid)
                {
                    try
                    {
                        name = AskForName().ToUpper();
                        CheckIfInputNameIsCorrect(name);
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
                Gamename = AskForGameName().ToUpper();

                User UserInput = new User(name, age);                
                userInputList[i] = UserInput;
                GameNameList[i] = Gamename;
               
            }

            for (int i = 0; i < numberinput; i++)
            {
                var user = userInputList[i];
                if (user.IsAdult)
                {
                    user.JoinGame(GameNameList[i]);

                    
                }
            }
         
        }

        public static string AskForGameName()
        {
            Console.WriteLine("Please enter the game name: ");
            return Console.ReadLine();
        }      
       

        public static int AskForNumber()
        {
            Console.WriteLine("Please insert a number:");
            int NumberInput = Convert.ToInt32(Console.ReadLine());
            return NumberInput;
        }

        public static void CheckNumberInput(int numberInput)
        {
            if (numberInput < 1 || numberInput > 12)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public static string AskForName()
        {
            Console.WriteLine("Please enter your name:");
            return Console.ReadLine();
        }

        public static void CheckIfInputNameIsCorrect(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c) && c != '-')
                {
                    throw new ArgumentException();
                }
            }
        }
        public static int AskForAge()
        {
            Console.WriteLine("Please enter your age:");
            int AgeInput = Convert.ToInt32(Console.ReadLine());
            return AgeInput;
        }


    }
}