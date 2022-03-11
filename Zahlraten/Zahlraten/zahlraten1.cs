using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlraten
{
    internal class zahlraten1
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Please type a number between 1 and 20");
            int random = GetRandom(1, 20);
            int num = 1;
            int answer;
            //Console.WriteLine(random);
            do
            {
                Console.Write("Your {0}. Number: ", num);
                answer = int.Parse(Console.ReadLine());
                if (answer > random)
                {
                    Console.WriteLine("the number is smaller.");
                }
                else if (answer < random)
                {
                    Console.WriteLine("the number is bigger.");
                }
                else
                {
                    Console.WriteLine("Congrats the corret number is ({0}) ", random);
                }
                num++;
            } while (answer != random);
        }

        private static int GetRandom(int lower, int upper)
        {
            Random r = new Random();
            return r.Next(lower, upper);
        }
    }

}

