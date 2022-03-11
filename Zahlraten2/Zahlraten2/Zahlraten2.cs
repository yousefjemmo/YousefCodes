using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlraten2
{
    internal class Zahlraten2
    {
        private static bool correctGuess = false;
        


        public static void Main(string[] args)
        {
           
            int min = 0;
            int max = 100;
            int counter = 0;
            string user;     


            Console.WriteLine("choose a number between 0 and 100! Done? Type anything and let's start");
            Console.ReadLine();          


            do
            {
                counter++;
                
                int guess = (max + min) / 2;

                Console.WriteLine($"Is it {guess}? (Y)es, (S)maller, (B)igger, (C)ancel");

                user = Console.ReadLine();

                if (user == "Y")
                {
                    Console.WriteLine($"You had {counter} tries");
                    correctGuess = true;    
                    
                }
                else if (user == "S")
                {
                    max = guess - 1;             
                }
                else if (user == "B")
                {
                    min = guess + 1;                 
                }
                else if (user == "C")
                {
                    Console.WriteLine("ok bye");
                    correctGuess = true;

                }
                else
                {
                    Console.WriteLine("Not valid!");
                    correctGuess = true;

                }
                if (min > max)
                {
                    Console.WriteLine("it can't be");
                    correctGuess = true;

                }            

            } while (correctGuess == false);


            


        }

       

    }
}


