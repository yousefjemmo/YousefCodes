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
            
            bool MaxPointsIsValid = false;
            int maxpoints = 0;
            while (!MaxPointsIsValid)
            {
                try
                {
                    maxpoints = AskForMaxPoints();  
                    CheckIfNumberOfPointsInRange(maxpoints);
                    MaxPointsIsValid = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Only between 2 and 10 points ");
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("You are only allowed to enter numbers");
                }
            }

            string UserChoice = AskWithWhoToPlay();


            while (gameloop)
            {


                if (UserChoice == "A")
                {
                    var PlayerOne = AskForInputAndCheckIt();
                    var PlayerTwo = AskForInputAndCheckIt();                  
                    var results = CompareTheAnswersBetweenPlayers(PlayerOne, PlayerTwo);

                    Console.WriteLine(results);
                    if (results == Player_Two_Won)
                    {
                        PlayerTwoPoints++;
                        var hasReachedHalfPoints = Program.HasReachedHalfPoints(maxpoints, PlayerTwoPoints);                     
                        if (hasReachedHalfPoints)
                        {
                            Console.WriteLine($"Player Two has now {PlayerTwoPoints} points!! ");
                            
                        }
                    }
                    else if (results == Player_One_Won)
                    {
                        PlayerOnePoints++;
                        var hasReachedHalfPoints = Program.HasReachedHalfPoints(maxpoints, PlayerOnePoints);
                        if (hasReachedHalfPoints)
                        {
                            Console.WriteLine($"Player One has now {PlayerOnePoints} points!! ");

                        }
                    }
                }
                else if (UserChoice == "B")
                {
                    var PlayerOne = AskForInputAndCheckIt();                   

                    Random randomChoice = new Random();
                    int Computer = randomChoice.Next(1, 4);

                    var results = CompareTheAnswersBetweenPlayers(PlayerOne, Computer);

                    if (Player_Two_Won == results)
                    {
                        Console.WriteLine(Computer_Won);
                    }
                    else
                    {
                        Console.WriteLine(results);
                    }                 
                    
                    if (results == Player_Two_Won)
                    {                        
                        Console.WriteLine($"Computer Choice: {Computer} \n ");
                        PlayerTwoPoints++;
                        var hasReachedHalfPoints = Program.HasReachedHalfPoints(maxpoints, PlayerTwoPoints);
                        if (hasReachedHalfPoints)
                        {
                            Console.WriteLine($"Player Two has now {PlayerTwoPoints} points!! ");

                        }
                    }
                    else if (results == Player_One_Won)
                    {                       
                        PlayerOnePoints++;
                        var hasReachedHalfPoints = Program.HasReachedHalfPoints(maxpoints, PlayerOnePoints);
                        if (hasReachedHalfPoints)
                        {
                            Console.WriteLine($"Player One has now {PlayerOnePoints} points!! ");

                        }
                    }
                }               


                if (PlayerOnePoints == maxpoints || PlayerTwoPoints == maxpoints)
                {
                    gameloop = false;
                    Console.WriteLine($"Player Two has {PlayerTwoPoints} points - Player One has {PlayerOnePoints} points");
                }

            }

        }

        private static int AskForMaxPoints()
        {
            Console.WriteLine("Please insert the Max points: ");
            int PointsInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            return PointsInput;
        } 
        
        public static void CheckIfNumberOfPointsInRange(int input)
        {
            if (input < 2 || input > 10)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public static string AskWithWhoToPlay()
        {
            bool IputCheck = false;
            string Input = "";
            Console.WriteLine("With who you want to play?");
            Console.WriteLine("A. Normal Player");
            Console.WriteLine("B. Computer \n");

            while (!IputCheck)
            {
                Input = Console.ReadLine().ToUpper();
                if (Input == "A" || Input == "B")
                {
                    IputCheck = true;
                }
                else
                {
                    Console.WriteLine("Either A or B. Try Again: ");
                }
            }
            return Input;
        }


        private static int AskForInputAndCheckIt()
        {
            Console.WriteLine("\nPlease enter a Number below for your choice and press enter:");

            Console.WriteLine("1.Rock");
            Console.WriteLine("2.Paper");
            Console.WriteLine("3.Scissors \n");

            
            bool IputCheckIsValidForPlayerOne = false;
            int input = 0;
            while (!IputCheckIsValidForPlayerOne)
            {                   
                input = Convert.ToInt32(Console.ReadLine());

                if (input == 1 || input == 2 || input == 3)
                {                    
                    Console.WriteLine($"Player: {input} \n");                    
                    IputCheckIsValidForPlayerOne = true;
                }
                else
                {
                    Console.WriteLine("Either 1 , 2 or 3. Try Again: ");                    
                }                
            }            
            return input;
        }    

        private static string Player_One_Won = "Player One Won!!";
        private static string Player_Two_Won = "Player Two Won!!";                                                             
        private static string Computer_Won = "Computer Won!!";                                                             
        private static string Tie = "It's a draw.";

        public static string CompareTheAnswersBetweenPlayers(int PlayerOne, int PlayerTwo)
        {

            switch (PlayerOne)
            {               

                case 1:
                    switch (PlayerTwo)
                    {
                        case 1:
                            return Tie;

                        case 2:
                            return Player_Two_Won;                           

                        case 3:
                            return Player_One_Won;    
                    }
                    break;

                case 2:
                    switch (PlayerTwo)
                    {
                        case 1:
                            return Player_One_Won;

                        case 2:
                            return Tie;

                        case 3:
                            return Player_Two_Won;                
                    }
                    break;

                case 3:
                    switch (PlayerTwo)
                    {
                        case 1:
                            return Player_Two_Won;
                           

                        case 2:
                            return Player_One_Won;

                        case 3:
                            return Tie; 
                    }
                    break;
            }
            return Tie;
            
        }   

        public static bool HasReachedHalfPoints(int maxpoints, int PlayerPoints)
        {     
            
            if (maxpoints % 2 != 0)
            {
                if (PlayerPoints == maxpoints / 2 + 1)       
                {
                    return true;
                }            
            }
            else
            {
                if (PlayerPoints == maxpoints / 2)
                {
                    return true;
                }              
            }
            return false;
            
        }

    }
}   