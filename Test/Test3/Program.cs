using System;

namespace Rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameloop = true;


            int PlayerOnePoints = 0;
            int PlayerTwoPoints = 0;

            while (gameloop)
            {
                var PlayerOne = AskForInput();

                var PlayerTwo = AskForInput();


               var results = Game(PlayerOne, PlayerTwo);



                if (results == Player_Two_Won)
                {

                    PlayerTwoPoints++;
                }
                else if (results == Player_One_Won)
                {
                    PlayerOnePoints++;
                }
                else
                {
                    
                }
                   


                if (PlayerOnePoints == 5 || PlayerTwoPoints == 5)
                {
                    gameloop = false;
                    Console.WriteLine($"Player Two has {PlayerTwoPoints} points - Player One has {PlayerOnePoints} points");
                }

            }
           


        }

        private static string AskForInput()
        {
            Console.WriteLine("\nPlease enter a Letter below for your choice and press enter:");

            Console.WriteLine("A.Rock");
            Console.WriteLine("B.Paper");
            Console.WriteLine("C.Scissors \n");

            
            bool IputCheckIsValidForPlayerOne = false;
            string input = "";
            while (!IputCheckIsValidForPlayerOne)
            {
                 

                input = Console.ReadLine().ToUpper();

                if (input == "A" || input == "B" || input == "C")
                {
                    int playercounter = 0;
                    playercounter++;
                    Console.WriteLine($"Player {playercounter}: {input} \n");
                    playercounter++;
                    IputCheckIsValidForPlayerOne = true;

                }
                else
                {
                    Console.Write("Either A , B or C. Try Again: ");                    
                }
                
            }
            
            return input;

        }

        private static string Player_One_Won = "Player One Won!!";
        private static string Player_Two_Won = "Player Two Won!!";
        private static string Tie = "It's a draw.";

        public static string Game(string PlayerOne, string PlayerTwo)
        {
            
           

            switch (PlayerOne)
            {               

                case "A":
                    if (PlayerTwo == "A")
                    {
                        Console.WriteLine("It is a draw");
                        return Tie;
                    }
                    else if (PlayerTwo == "B")
                    {
                        Console.WriteLine("Player Two Won!!");
                        return Player_Two_Won;
                        
                    }
                    else if (PlayerTwo == "C")
                    {
                        Console.WriteLine("Player One Won!!");
                        return Player_One_Won;
                    }
                    break;

                case "B":
                    if (PlayerTwo == "A")
                    {
                        Console.WriteLine("Player One Won!!");
                        return Player_One_Won;
                    }

                    else if (PlayerTwo == "B")
                    {
                        Console.WriteLine("It is a draw");
                        return Tie;
                    }
                    else if (PlayerTwo == "C")
                    {
                        Console.WriteLine("Player Two Won!!");
                        return Player_Two_Won;
                    }
                    break;

                case "C":
                    if (PlayerTwo == "A")
                    {

                        Console.WriteLine("Player Two Won!!");
                        return Player_Two_Won;
                    }

                    else if (PlayerTwo == "B")
                    {
                        Console.WriteLine("Player One Won!!");
                        return Player_One_Won;

                    }
                    else if (PlayerTwo == "C")
                    {
                        Console.WriteLine("It is a tie");
                        return Tie;
                    }
                    break;

                


            }

            return Tie;
            
        }

       

      

                 
           
        


    }
}   