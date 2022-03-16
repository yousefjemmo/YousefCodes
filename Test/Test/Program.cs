using System;

namespace Rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameLoop = true;
            int PlayerOnePoints = 0;
            int PlayerTwoPoints = 0;
            while (gameLoop)
            {
                Console.WriteLine("Please enter a Alphapet below for your choice and press enter:");

                Console.WriteLine("A.Rock");
                Console.WriteLine("B.Paper");
                Console.WriteLine("C.Scissors");
                string PlayerOne = Console.ReadLine();
                string PlayerTwo = Console.ReadLine();

                switch (PlayerOne)
                {
                    case "A":
                        if (PlayerTwo == "A")
                        {
                            Console.WriteLine("PlayerTwo chose Rock");
                            Console.WriteLine("PlayerOne chose Rock");
                            Console.WriteLine("It is a tie.");
                        }

                        else if (PlayerTwo == "B")
                        {
                            Console.WriteLine("PlayerTwo chose Paper");
                            Console.WriteLine("PlayerOne chose Rock");
                            Console.WriteLine("PlayerTwo wins");
                            PlayerTwoPoints++;
                            Console.WriteLine($"Player Two has {PlayerTwoPoints} points - Player One has {PlayerOnePoints} points");
                        }
                        else if (PlayerTwo == "C")
                        {
                            Console.WriteLine("PlayerTwo chose Scissors");
                            Console.WriteLine("PlayerOne chose Rock");
                            Console.WriteLine("PlayerOne wins");
                            PlayerOnePoints++;
                            Console.WriteLine($"Player Two has {PlayerTwoPoints} points - Player One has {PlayerOnePoints} points");
                        }
                        break;

                    case "B":
                        if (PlayerTwo == "A")
                        {

                            Console.WriteLine("PlayerTwo chose Rock");
                            Console.WriteLine("PlayerOne chose Rock");
                            Console.WriteLine("It is a tie.");
                        }

                        else if (PlayerTwo == "B")
                        {
                            Console.WriteLine("PlayerTwo chose Paper");
                            Console.WriteLine("PlayerOne chose Rock");
                            Console.WriteLine("PlayerTwo wins");
                            PlayerTwoPoints++;
                            Console.WriteLine($"Player Two has {PlayerTwoPoints} points - Player One has {PlayerOnePoints} points");
                        }
                        else if (PlayerTwo == "C")
                        {
                            Console.WriteLine("PlayerTwo chose Scissors");
                            Console.WriteLine("PlayerOne chose Rock");
                            Console.WriteLine("PlayerOne wins");
                            PlayerOnePoints++;
                            Console.WriteLine($"Player Two has {PlayerTwoPoints} points - Player One has {PlayerOnePoints} points");
                        }
                        break;

                    case "C":
                        if (PlayerTwo == "A")
                        {

                            Console.WriteLine("PlayerTwo chose Rock");
                            Console.WriteLine("PlayerOne chose Rock");
                            Console.WriteLine("PlayerTwo wins");
                            PlayerTwoPoints++;
                            Console.WriteLine($"Player Two has {PlayerTwoPoints} points - Player One has {PlayerOnePoints} points");
                        }

                        else if (PlayerTwo == "B")
                        {
                            Console.WriteLine("PlayerTwo chose Paper");
                            Console.WriteLine("PlayerOne chose Rock");
                            Console.WriteLine("PlayerOne wins");
                            PlayerOnePoints++;
                            Console.WriteLine($"Player Two has {PlayerTwoPoints} points - Player One has {PlayerOnePoints} points");

                        }
                        else if (PlayerTwo == "C")
                        {
                            Console.WriteLine("PlayerTwo chose Scissors");
                            Console.WriteLine("PlayerOne chose Rock");
                            Console.WriteLine("It is a tie");


                        }
                        break;
                }

                if (PlayerOnePoints == 5 || PlayerTwoPoints == 5)
                {
                    gameLoop = false;
                    Console.WriteLine($"Player Two has {PlayerTwoPoints} points - Player One has {PlayerOnePoints} points");
                }


            }




        }
    }
}