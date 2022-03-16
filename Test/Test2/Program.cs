using System;

namespace Rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameLoop = true;
            int userPoints = 0;
            int computerPoints = 0;

            while (gameLoop)
            {

                Console.WriteLine("Hello and welcome to my Rock, Paper, Scissors game. Please enter a number below for your choice and press enter:");

                Console.WriteLine("1.Rock");
                Console.WriteLine("2.Paper");
                Console.WriteLine("3.Scissors");
            }
            string userChoice = Console.ReadLine();
            Random randomChoice = new Random();
            int computerChoice = randomChoice.Next(1, 4);

            switch (computerChoice)
            {
                case 1:
                    if (userChoice == "1")
                    {

                        //this is a tie
                        Console.WriteLine("User chose Rock");
                        Console.WriteLine("Computer chose Rock");
                        Console.WriteLine("It is a tie.");
                    }

                    else if (userChoice == "2")
                    {
                        Console.WriteLine("User chose Paper");
                        Console.WriteLine("Computer chose Rock");
                        Console.WriteLine("User wins");
                        userPoints++;
                    }
                    else if (userChoice == "3")
                    {
                        Console.WriteLine("User chose Scissors");
                        Console.WriteLine("Computer chose Rock");
                        Console.WriteLine("Computer wins");
                        computerPoints++;
                    }
                    break;
                case 2:
                    if (userChoice == "1")
                    {

                        //this is a tie
                        Console.WriteLine("User chose Rock");
                        Console.WriteLine("Computer chose Rock");
                        Console.WriteLine("It is a tie");
                    }

                    else if (userChoice == "2")
                    {
                        Console.WriteLine("User chose Paper");
                        Console.WriteLine("Computer chose Rock");
                        Console.WriteLine("User wins");
                        userPoints++;
                    }
                    else if (userChoice == "3")
                    {
                        Console.WriteLine("User chose Scissors");
                        Console.WriteLine("Computer chose Rock");
                        Console.WriteLine("Computer wins");
                        computerPoints++;
                    }
                    break;

                case 3: //computer chose scissors
                    if (userChoice == "1")
                    {

                        //this is a tie
                        Console.WriteLine("User chose Rock");
                        Console.WriteLine("Computer chose Scissors");
                        Console.WriteLine("User wins.");
                        userPoints++;
                    }

                    else if (userChoice == "2")
                    {
                        Console.WriteLine("User chose Paper");
                        Console.WriteLine("Computer chose Scissors");
                        Console.WriteLine("Computer wins");
                        computerPoints++;
                    }
                    else if (userChoice == "3")
                    {
                        Console.WriteLine("User chose Scissors");
                        Console.WriteLine("Computer chose Scissors");
                        Console.WriteLine("It is a tie");
                    }
                    break;
            }           
           

        }
    }
}
